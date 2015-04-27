﻿namespace FS.SMIS_Cloud.NGDAC.Tran
{
    using System;
    using System.Linq;
    using System.Threading;

    using log4net;

    public delegate void MessageSendListener(TranMsg req, TranMsg resp);

    public class TranDataSender
    {
        private static ILog Log = LogManager.GetLogger("TranDataSender");

        public const int NO_DATA_WAIT_SECONDS = 5;
        public const int DTU_SEND_TIMEOUT = 5;

        private ITranDataProvider[] _providers;
        private ITranDataSendDelegator _delegator;
        private CancellationToken _token;
        private CancellationTokenSource _source;
        private System.Threading.Tasks.Task _task;
        public MessageSendListener OnMessageSent;

        public int Remainder
        {
            get
            {
                if (this._providers == null)
                    return 0;
                int tp = this._providers.Sum(pi => pi.Remainder);
                return tp;
            }
        }

        public TranDataSender(ITranDataSendDelegator sender, params ITranDataProvider[] providers)
        {
            this._providers = providers;
            this._delegator = sender;
        }

        public void DoWork()
        {
            if (this._task == null)
            {
                this._source = new CancellationTokenSource();
                this._token = this._source.Token;
                this._task = System.Threading.Tasks.Task.Factory.StartNew(this._run, this._token);
            }
        }

        private void _run()
        {
            while (!this._source.IsCancellationRequested)
            {
                if (!this._delegator.IsConnected())
                {
                    Log.InfoFormat("Reconnecting to delegate");
                    this._delegator.Connect();
                    Thread.Sleep(200);
                    if (!this._delegator.IsConnected())
                    {
                        Log.InfoFormat("Connecting error, retry after 1 second.");
                        Thread.Sleep(1000);
                        continue;
                    }
                    else
                    {
                        Log.InfoFormat("Connected.");
                    }
                }
                foreach (ITranDataProvider _provider in this._providers)
                {
                    if (this._source.IsCancellationRequested)
                        break;
                    if (_provider.HasMoreData()) //未发送完毕
                    {
                        if (this._source.IsCancellationRequested)
                            break;
                        int len = 0;
                        TranMsg[] msgs = _provider.NextPackages(out len);
                        int sendingIdx = 0;
                        bool allMsgSent = false;
                        long started = System.DateTime.Now.Ticks;
                        while (sendingIdx < msgs.Length) // 循环发送
                        {
                            if (this._source.IsCancellationRequested)
                                break;
                            TranMsg m = msgs[sendingIdx];
                            Log.DebugFormat("Sending package: {0}: {1}/{2}, len={3}", m.ID, sendingIdx, msgs.Length, m.LoadSize);
                            try
                            {
                                TranAckMsg ack;
                                if (this._delegator.SSend(m, DTU_SEND_TIMEOUT, out ack))
                                {
                                    if (!this.IsValidAck(m, ack)) {
                                    {
                                        Log.ErrorFormat("Sent failed, ack error, {0}!={1}", m.LoadSize, ack.Received);
                                        continue; // resent it.
                                    }}
                                    sendingIdx++; //发送成功.
                                    if (this.OnMessageSent != null)
                                    {
                                        this.OnMessageSent.Invoke(m, ack); //异步
                                    }
                                    allMsgSent = sendingIdx == msgs.Length;
                                    Thread.Sleep(100);
                                }
                                else
                                {
                                    Log.ErrorFormat("Sending error: {0}, retry after 2 second: ", ack.ErrorMsg);
                                    Thread.Sleep(1000);
                                }
                            }
                            catch (Exception e)
                            {
                                Log.ErrorFormat("Sending exception: {0}: ", e.Message);
                                Thread.Sleep(1000);
                            }
                        }
                        if (allMsgSent)
                        {
                            Log.DebugFormat("Package Group sent in {0} seconds.",
                                (System.DateTime.Now.Ticks - started)/10000);
                            _provider.OnPackageSent();
                        }
                        Thread.Sleep(10);
                    }
                    else
                    {
                        Log.InfoFormat("No more data. wait {0} seconds.", NO_DATA_WAIT_SECONDS);
                        Thread.Sleep(NO_DATA_WAIT_SECONDS*1000);
                    }
                }
            }
        }

        private bool IsValidAck(TranMsg req, TranAckMsg resp)
        {
            return resp.Received == req.LoadSize || resp.ID != req.ID;
        }

        public bool Stop()
        {
            if (this._task == null)
                return true;
            bool comp = false;
            try
            {
                this._source.Cancel();
                // _task.Wait();
                comp = this._task.IsCompleted;
                this._task = null;
                this._delegator.Disconnect();
                Log.InfoFormat("Sender stopped.");
            }
            catch (Exception ce)
            {
                Log.InfoFormat("Stopping error: {0}.", ce.Message);
            }
            return comp;
        }
 
    }
}
