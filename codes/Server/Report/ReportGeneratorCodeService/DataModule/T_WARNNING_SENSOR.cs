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
    
    public partial class T_WARNNING_SENSOR
    {
        public int ID { get; set; }
        public int WARNNING_TYPE_ID { get; set; }
        public int SENSOR_ID { get; set; }
        public decimal WARNNINGDATA { get; set; }
        public System.DateTime InsertTime { get; set; }
        public decimal AlertValue { get; set; }
        public byte AlertLevel { get; set; }
        public bool DealFlag { get; set; }
    }
}
