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
    
    public partial class T_DIM_FORMULAID_SET
    {
        public int FORMAULA_SETID { get; set; }
        public Nullable<int> SENSOR_ID { get; set; }
        public Nullable<int> FormulaParaID1 { get; set; }
        public Nullable<decimal> Parameter1 { get; set; }
        public Nullable<int> FormulaParaID2 { get; set; }
        public Nullable<decimal> Parameter2 { get; set; }
        public Nullable<int> FormulaParaID3 { get; set; }
        public Nullable<decimal> Parameter3 { get; set; }
        public Nullable<int> FormulaParaID4 { get; set; }
        public Nullable<decimal> Parameter4 { get; set; }
        public Nullable<int> FormulaParaID5 { get; set; }
        public Nullable<decimal> Parameter5 { get; set; }
        public Nullable<int> FormulaParaID6 { get; set; }
        public Nullable<decimal> Parameter6 { get; set; }
        public Nullable<int> FormulaParaID7 { get; set; }
        public Nullable<decimal> Parameter7 { get; set; }
        public Nullable<int> FormulaParaID8 { get; set; }
        public Nullable<int> Parameter8 { get; set; }
    
        public virtual T_DIM_FORMULA_PARA T_DIM_FORMULA_PARA { get; set; }
        public virtual T_DIM_SENSOR T_DIM_SENSOR { get; set; }
    }
}
