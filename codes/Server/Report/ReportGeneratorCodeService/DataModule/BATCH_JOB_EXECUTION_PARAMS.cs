//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportGeneratorService.DataModule
{
    using System;
    using System.Collections.Generic;
    
    public partial class BATCH_JOB_EXECUTION_PARAMS
    {
        public long JOB_EXECUTION_ID { get; set; }
        public string TYPE_CD { get; set; }
        public string KEY_NAME { get; set; }
        public string STRING_VAL { get; set; }
        public Nullable<System.DateTime> DATE_VAL { get; set; }
        public Nullable<long> LONG_VAL { get; set; }
        public Nullable<double> DOUBLE_VAL { get; set; }
        public string IDENTIFYING { get; set; }
    
        public virtual BATCH_JOB_EXECUTION BATCH_JOB_EXECUTION { get; set; }
    }
}
