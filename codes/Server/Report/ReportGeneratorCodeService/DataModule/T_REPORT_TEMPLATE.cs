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
    
    public partial class T_REPORT_TEMPLATE
    {
        public T_REPORT_TEMPLATE()
        {
            this.T_REPORT_CONFIG_TEMPLATE = new HashSet<T_REPORT_CONFIG_TEMPLATE>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string HandleName { get; set; }
        public string Description { get; set; }
        public Nullable<int> FactorId { get; set; }
        public int Type { get; set; }
    
        public virtual ICollection<T_REPORT_CONFIG_TEMPLATE> T_REPORT_CONFIG_TEMPLATE { get; set; }
    }
}
