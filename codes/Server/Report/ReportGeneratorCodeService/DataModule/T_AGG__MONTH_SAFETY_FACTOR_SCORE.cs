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
    
    public partial class T_AGG__MONTH_SAFETY_FACTOR_SCORE
    {
        public int ID { get; set; }
        public Nullable<int> DATETIME_ID { get; set; }
        public string MONTH_CODE { get; set; }
        public string MONTH_FULL_CN { get; set; }
        public string MONTH_SHORT_CN { get; set; }
        public string QUARTER_CODE { get; set; }
        public string HALF_YEAR_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public Nullable<int> ORG_STRUC_ID { get; set; }
        public Nullable<int> SAFETY_FACTOR_TYPE_ID { get; set; }
        public string SAFETY_FACTOR_TYPE_NAME { get; set; }
        public Nullable<byte> SAFETY_FACTOR_HIGH_SCORE { get; set; }
        public Nullable<System.DateTime> SAFETY_FACTOR_HIGH_SCORE_DATETIME { get; set; }
        public Nullable<byte> SAFETY_FACTOR_LOW_SCORE { get; set; }
        public Nullable<System.DateTime> SAFETY_FACTOR_LOW_SCORE_DATETIME { get; set; }
        public Nullable<byte> SAFETY_FACTOR_AVG_SCORE { get; set; }
        public Nullable<System.DateTime> SAFETY_FACTOR_AVG_SCORE_DATETIME { get; set; }
        public string ABB_NAME_CN { get; set; }
        public string FULL__NAME_CN { get; set; }
        public string TRIAL_NAME_CN { get; set; }
        public string STRUCTURE_NAME_CN { get; set; }
        public string STRUCTURE_ALIAS_CN { get; set; }
        public string STRUCTURE_TRIAL_CN { get; set; }
    
        public virtual T_DIM_DATETIME T_DIM_DATETIME { get; set; }
        public virtual T_DIM_ORG_STUCTURE T_DIM_ORG_STUCTURE { get; set; }
        public virtual T_DIM_SAFETY_FACTOR_TYPE T_DIM_SAFETY_FACTOR_TYPE { get; set; }
    }
}
