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
    
    public partial class T_DATA_STABLE_FILTER_CONFIG
    {
        public int Id { get; set; }
        public int SensorId { get; set; }
        public int ItemId { get; set; }
        public bool Enabled { get; set; }
        public Nullable<int> WindowSize { get; set; }
        public Nullable<decimal> KT { get; set; }
        public Nullable<int> DT { get; set; }
        public Nullable<int> RT { get; set; }
        public bool NeedLog { get; set; }
    }
}
