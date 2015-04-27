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
    
    public partial class T_THEMES_DEFORMATION_DEEP_DISPLACEMENT
    {
        public int ID { get; set; }
        public Nullable<int> SENSOR_ID { get; set; }
        public int SAFETY_FACTOR_TYPE_ID { get; set; }
        public Nullable<decimal> PHYSICAL_QUANTITY_X_VALUE { get; set; }
        public Nullable<decimal> DEEP_DISPLACEMENT_X_VALUE { get; set; }
        public Nullable<byte> DEEP_DISPLACEMENT_X_SCORE { get; set; }
        public Nullable<decimal> PHYSICAL_QUANTITY_Y_VALUE { get; set; }
        public Nullable<decimal> DEEP_DISPLACEMENT_Y_VALUE { get; set; }
        public Nullable<byte> DEEP_DISPLACEMENT_Y_SCORE { get; set; }
        public Nullable<System.DateTime> ACQUISITION_DATETIME { get; set; }
        public Nullable<int> ORDERBY_COLUMN { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<decimal> TEMPERATURE_VALUE { get; set; }
        public Nullable<decimal> DEEP_CUMULATIVEDISPLACEMENT_X_VALUE { get; set; }
        public Nullable<decimal> DEEP_CUMULATIVEDISPLACEMENT_Y_VALUE { get; set; }
        public string RESERVED_FIELD_4 { get; set; }
        public string RESERVED_FIELD_5 { get; set; }
        public Nullable<byte> Score { get; set; }
    
        public virtual T_DIM_SAFETY_FACTOR_TYPE T_DIM_SAFETY_FACTOR_TYPE { get; set; }
        public virtual T_DIM_SAFETY_FACTOR_TYPE T_DIM_SAFETY_FACTOR_TYPE1 { get; set; }
        public virtual T_DIM_SENSOR T_DIM_SENSOR { get; set; }
        public virtual T_DIM_SENSOR T_DIM_SENSOR1 { get; set; }
    }
}
