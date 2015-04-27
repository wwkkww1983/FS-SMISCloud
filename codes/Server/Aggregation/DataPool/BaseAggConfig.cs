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

namespace Agg.DataPool
{
    using System.Data;

    using Agg.Comm.DataModle;
    using Agg.Storage;
    using log4net;
    [Serializable]
    public class BaseAggConfig
    {
        //private ThemeTableInfo themeTableInfo;

        private AggTaskKey key;

        private int configid;

        public int ConfigId{
            get
            {
                return this.configid;
            }
            protected set
            {
                this.configid = value;
            }
        }

        private List<int> sensorIds=new List<int>();

        private DateTime sensorIdLastUpdateTime;

        private string timeMode;

        private static SeclureCloudDbHelper DbHelper = SeclureCloudDbHelper.Instance();

        private static ILog log = LogManager.GetLogger("BaseAggConfig");
        /// <summary>
        /// sensorID检查更新过期时间,单位：小时
        /// </summary>
        private const int ExpTime = 1;

       
        public BaseAggConfig(AggTaskKey key)
        {
            this.key = key;
            //this.themeTableInfo = new ThemeTableInfo(this.FactorId);
            this.sensorIdLastUpdateTime = DateTime.MinValue;
            this.TimeRange = new AggTimeRange();
        }

        public AggTaskKey Key 
        {
            get
            {
                return this.key;
            }
        }

        public virtual int StructId
        {
            get
            {
                return this.key.StructId;
            }
        }

        public virtual int FactorId
        {
            get
            {
                return this.key.FactorId;
            }
        }

        public List<int> GetSensorIds()
        {
            if (sensorIds == null || sensorIds.Count == 0)
            {
                sensorIds = DbHelper.Accessor.GetSensorIds(StructId, FactorId);
            }
            else
            {
                if ((DateTime.Now - sensorIdLastUpdateTime).Hours > ExpTime)
                {
                    ///检查传感器ID是否有变更
                    if (DbHelper.Accessor.IsSensorIdUpdated(StructId, FactorId, sensorIds))
                    {
                        sensorIds = DbHelper.Accessor.GetSensorIds(StructId, FactorId);
                    }
                    sensorIdLastUpdateTime = DateTime.Now;
                }
            }
            

            return sensorIds;

        }

        public virtual AggTimeRange TimeRange { get; set;}

        public AggType Type {
            get
            {
                return key.Type;
            }
        }

        public virtual AggWay Way { get; set; }

        public virtual string TimingMode
        {
            get
            {
                return this.timeMode;
            }
            protected set
            {
                string temp = this.ToTimeMode(Type, value);
                if(temp == string.Empty)
                    throw new ArgumentException(string.Format("time 格式错误，type:{0},time:{1}", Type, value));
                else
                {
                    this.timeMode = temp;
                }
            }

        }

        protected virtual string ToTimeMode(AggType type, string timeString)
        {
            string timemode = string.Empty;
            int hour;
            int day;
            int weekIndex;
            string[] tmp;
            switch (type)
            {
                case AggType.Day:
                    
                    if(int.TryParse(timeString.Trim(), out hour))
                    {
                        if (isCornTimeHourValid(hour))
                        {
                            timemode = string.Format("0 0 {0} * * ?", timeString);
                        }
                        
                    }
                    break;
                case AggType.Week:
                    tmp = timeString.Trim().Split(',');
                    if (tmp.Count() == 2 && int.TryParse(tmp[1].Trim(), out hour) && int.TryParse(tmp[0].Trim(), out day))
                    {
                        if (isCornTimeHourValid(hour) && isCornTimeDayOfWeekValid(day))
                        {
                            timemode = string.Format("0 0 {0} ? * {1}", hour, day);
                        }
                    }
                    break;
                case AggType.Month:
                    tmp = timeString.Trim().Split(',');
                    if (tmp.Count() == 2 && int.TryParse(tmp[1].Trim(), out hour) && int.TryParse(tmp[0].Trim(), out day))
                    {
                        if (isCornTimeHourValid(hour) && isCornTimeDayOfMonthValid(day))
                        {
                            timemode = string.Format("0 0 {0} {1} * ?", hour, day == -1 ? "L" : day.ToString());
                        }
                    }
                    else if (tmp.Count() == 3 && int.TryParse(tmp[2].Trim(), out hour)
                             && int.TryParse(tmp[1].Trim(), out day) && int.TryParse(tmp[0].Trim(), out weekIndex))
                    {
                        if (isCornTimeHourValid(hour) && isCornTimeDayOfWeekValid(day))
                        {
                            if (weekIndex == -1) ///最后一个星期
                            {
                                timemode = string.Format("0 0 {0} ? * {1}L", hour, day);
                            }
                            else
                            {
                                timemode = string.Format("0 0 {0} ? * {1}#{2}", hour, day, weekIndex);
                            }

                        }
                       
                    }
                    break;
                default:
                    break;

            }
            return timemode;
        }

        private static bool isCornTimeHourValid(int hour)
        {
            return (hour >= 0 && hour < 24);
        }

        private static bool isCornTimeDayOfWeekValid(int day)
        {
            return (day >= -1 && day <= 7);
        }

        private static bool isCornTimeDayOfMonthValid(int day)
        {
            return (day >= 1 && day <= 31);
        }

        public static List<BaseAggConfig> Create(DataTable dt)
        {
            List<BaseAggConfig> configs = new List<BaseAggConfig>();
            if (dt == null) return configs;

            int id=0;
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    id =Convert.ToInt32(dr["Id"]);
                    AggType type;
                    AggWay way;
                    if (!AggType.TryParse(Convert.ToString(dr["AggTypeId"]), out type))
                    {
                        log.WarnFormat("create config failed,aggtype wrong.ConfigId:{0}", id);
                        continue;
                    }
                    if (!AggWay.TryParse(Convert.ToString(dr["AggWayId"]), out way))
                    {
                        log.WarnFormat("create config failed,aggway wrong.ConfigId:{0}", id);
                        continue;
                    }
                    AggTaskKey key = new AggTaskKey(Convert.ToInt32(dr["StructureId"]), Convert.ToInt32(dr["FacotrId"]), type);
                    BaseAggConfig config = new BaseAggConfig(key);
                    config.TimeRange = new AggTimeRange
                                           {
                                               DataBeginHour = Convert.ToInt32(dr["DataBeginHour"]),
                                               DataEndHour = Convert.ToInt32(dr["DataEndHour"]),
                                               //DateBegin = Convert.ToInt32(dr["DateBegin"]),
                                               //DateEnd = Convert.ToInt32(dr["DateEnd"])
                                           };
                    if (dr["DateBegin"].ToString() != string.Empty)
                    {
                        config.TimeRange.DateBegin = Convert.ToInt32(dr["DateBegin"]);
                    }
                    if (dr["DateEnd"].ToString() != string.Empty)
                    {
                        config.TimeRange.DateEnd = Convert.ToInt32(dr["DateEnd"]);
                    }
                    config.TimingMode = Convert.ToString(dr["TimeMode"]);
                    config.Way = way;
                    config.ConfigId = id;
                    configs.Add(config);
                }
                catch (Exception e)
                {
                    log.WarnFormat("create config error,configId:{0},error:{1},trace:{2}", id,e.Message,e.StackTrace);
                    continue;
                }
            }
            return configs;
        }

        //public ThemeTableInfo ThemeTableInfo { get; set; }
    }
}


