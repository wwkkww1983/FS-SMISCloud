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
    
    public partial class T_DIM_PROTOCOLCOMMAND
    {
        public short COMMAND_ID { get; set; }
        public Nullable<short> PROTOCOL_ID { get; set; }
        public Nullable<int> PROTOCOL_TYPE_ID { get; set; }
        public Nullable<int> DAI_PRODUCT_ID { get; set; }
        public Nullable<int> COMMAND_TYPE { get; set; }
        public string COMMAND_CONTENT { get; set; }
        public string DESCRIPTION { get; set; }
    
        public virtual T_DIM_PROTOCOL_TYPE T_DIM_PROTOCOL_TYPE { get; set; }
    }
}
