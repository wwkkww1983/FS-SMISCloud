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
    
    public partial class T_DIM_FORMULA_PARA_NAME
    {
        public T_DIM_FORMULA_PARA_NAME()
        {
            this.T_DIM_FORMULA_PARA = new HashSet<T_DIM_FORMULA_PARA>();
        }
    
        public int ParaNameID { get; set; }
        public string ParaName { get; set; }
        public string ParaAlias { get; set; }
    
        public virtual ICollection<T_DIM_FORMULA_PARA> T_DIM_FORMULA_PARA { get; set; }
    }
}
