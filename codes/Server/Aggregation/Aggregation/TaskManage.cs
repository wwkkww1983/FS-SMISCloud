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

namespace Aggregation
{
    using Agg.Comm.DataModle;
    using Agg.DataPool;

    /// <summary>
    /// 任务创建及管理类
    /// </summary>
    public class TaskManage
    {
        
        //private static object _lock = new object();

        //private static TaskManage instance;   

        public TaskManage(List<BaseAggConfig> aggConfigs, AggJobManage manage)
        {

        }

        //public TaskManage Instance()
        //{
        //    if (instance == null)
        //    {
        //        lock (_lock)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new TaskManage();
        //            }
        //        }
        //    }
        //    return instance;
        //}

        public void UpdateAggConfig(BaseAggConfig config)
        {

        }


        private bool Init()
        {
           // this.CreateTask();
            return true;
        }

        private static void CreateTask(List<BaseAggConfig> configs)
        {


        }
    }

}




