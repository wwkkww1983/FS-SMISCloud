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
    
    public partial class T_DIM_ROLE_RESOURCE
    {
        public short ROLE_ID { get; set; }
        public byte OPERATION_RES_ID { get; set; }
    
        public virtual T_DIM_OPERATION_RESOURCE T_DIM_OPERATION_RESOURCE { get; set; }
    }
}
