﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;

namespace Agg.DataPool
{
    using System.Reflection;

    using Agg.Comm.DataModle;
    using Agg.Comm.Util;
   
    using Agg.Storage;
    using System.Threading;

    using log4net;

    internal abstract class DBDataPoolBase : IDataPool
    {
       // protected string ThemeTableName { set; get; }

       // protected AggType AggType { set;get; }

        protected SeclureCloudDbHelper DbHelper;

        //protected ConcurrentBag<int> SensorIds { get; set; }

        protected const int TimeOut = 1000;

        protected ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected ReaderWriterLockSlim rwLocker = new ReaderWriterLockSlim();

        protected BaseAggConfig config;

        public virtual BaseAggConfig Config {
            set
            {
                if (rwLocker.TryEnterWriteLock(TimeOut))
                {
                    try
                    {
                        this.config = value;
                    }
                    finally 
                    {

                        rwLocker.ExitWriteLock();
                    }
                    
                    //this.Init();
                    
                }
                else
                {
                    Log.WarnFormat("Struceure:{0} FactorId:{1} AggType:{2}, Obtain Lock TimeOut", this.config.StructId,this.config.FactorId,this.config.Type.ToString());
                }
            }
            get
            {
                return this.config;
            }
        }

        /// <summary>
        /// DataPool初始化
        /// </summary>
        protected virtual void Init()
        {
            //if (DbHelper != null && this.config != null)
            //{
            //    SensorIds = new ConcurrentBag<int>(DbHelper.Accessor.GetSensorIds(config.StructId, config.FactorId));
            //    ColNum = DbHelper.Accessor.GetColNum(this.config.ThemeTableInfo.ThemeTableName);
            //}
            //else
            //{
            //    Log.WarnFormat("Struceure:{0} FactorId:{1} AggType:{2}, Init Failed", this.config.StructId, this.config.FactorId, this.config.Type.ToString());
            //}
        }


        protected DBDataPoolBase()
        {
            this.DbHelper = SeclureCloudDbHelper.Instance();
            //this.config = new BaseAggConfig();
        }



        public virtual AggRawData GetAggRawData(DateTime nowTime)
        {
            throw new System.NotImplementedException();
        }

        protected virtual List<AggData> GetLastAggData()
        {
            if (DbHelper == null) return null;

            //if(!rwLocker.TryEnterReadLock(TimeOut))
            //    return null;
            //BaseAggConfig configTmp = ObjectHelper.DeepCopy(this.Config);
            //rwLocker.ExitReadLock();

            int dateTimeId = DbHelper.Accessor.GetLastestDateTimeId(
                config.StructId,
                config.FactorId,
                config.Type);
            if(dateTimeId == -1)
                return null;

            List<int> sensorIds = config.GetSensorIds();
            List<AggData> aggDatas = new List<AggData>();
            foreach (int id in sensorIds)
            {
                AggData aggData = DbHelper.Accessor.GetLastestAggData(id, config.Type, dateTimeId);
                if (aggData != null)
                {
                    aggDatas.Add(aggData);
                }
            }
            return aggDatas;
        }

        protected abstract string GetTimeFlg(DateTime time);
       
        [Obsolete("数据库类型数据池不使用该方法", true)]
        public void AddNewData(AggRawData newDatas)
        {
            throw new System.NotImplementedException();
        }

    }
}

