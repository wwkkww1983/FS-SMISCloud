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
    
    public partial class T_DIM_WARNING_DEVICETYPE
    {
        public T_DIM_WARNING_DEVICETYPE()
        {
            this.T_WARNING_SENSOR = new HashSet<T_WARNING_SENSOR>();
        }
    
        public int Id { get; set; }
        public string DeviceTypeCode { get; set; }
        public string Remarks { get; set; }
    
        public virtual ICollection<T_WARNING_SENSOR> T_WARNING_SENSOR { get; set; }
    }
}
