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
    
    public partial class T_DIM_SECTION
    {
        public T_DIM_SECTION()
        {
            this.T_DIM_HOTSPOT = new HashSet<T_DIM_HOTSPOT>();
            this.T_DIM_HOTSPOT_SECTION = new HashSet<T_DIM_HOTSPOT_SECTION>();
        }
    
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public Nullable<int> SectionStatus { get; set; }
        public string HeapMapName { get; set; }
        public int StructId { get; set; }
    
        public virtual ICollection<T_DIM_HOTSPOT> T_DIM_HOTSPOT { get; set; }
        public virtual ICollection<T_DIM_HOTSPOT_SECTION> T_DIM_HOTSPOT_SECTION { get; set; }
        public virtual T_DIM_STRUCTURE T_DIM_STRUCTURE { get; set; }
    }
}
