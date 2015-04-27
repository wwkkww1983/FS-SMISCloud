//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeSun.FS_SMISCloud.Server.CloudApi.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BATCH_JOB_EXECUTION
    {
        public BATCH_JOB_EXECUTION()
        {
            this.BATCH_JOB_EXECUTION_PARAMS = new HashSet<BATCH_JOB_EXECUTION_PARAMS>();
            this.BATCH_STEP_EXECUTION = new HashSet<BATCH_STEP_EXECUTION>();
        }
    
        public long JOB_EXECUTION_ID { get; set; }
        public Nullable<long> VERSION { get; set; }
        public long JOB_INSTANCE_ID { get; set; }
        public System.DateTime CREATE_TIME { get; set; }
        public Nullable<System.DateTime> START_TIME { get; set; }
        public Nullable<System.DateTime> END_TIME { get; set; }
        public string STATUS { get; set; }
        public string EXIT_CODE { get; set; }
        public string EXIT_MESSAGE { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED { get; set; }
        public string JOB_CONFIGURATION_LOCATION { get; set; }
    
        public virtual BATCH_JOB_EXECUTION_CONTEXT BATCH_JOB_EXECUTION_CONTEXT { get; set; }
        public virtual ICollection<BATCH_JOB_EXECUTION_PARAMS> BATCH_JOB_EXECUTION_PARAMS { get; set; }
        public virtual ICollection<BATCH_STEP_EXECUTION> BATCH_STEP_EXECUTION { get; set; }
        public virtual BATCH_JOB_INSTANCE BATCH_JOB_INSTANCE { get; set; }
    }
}
