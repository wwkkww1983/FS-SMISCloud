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
    
    public partial class T_DIM_GROUP
    {
        public T_DIM_GROUP()
        {
            this.T_DIM_SENSOR_GROUP_CHENJIANG = new HashSet<T_DIM_SENSOR_GROUP_CHENJIANG>();
            this.T_DIM_SENSOR_GROUP_JINRUNXIAN = new HashSet<T_DIM_SENSOR_GROUP_JINRUNXIAN>();
            this.T_DIM_SENSOR_GROUP_CEXIE = new HashSet<T_DIM_SENSOR_GROUP_CEXIE>();
        }
    
        public int GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public int GROUP_TYPE_ID { get; set; }
    
        public virtual ICollection<T_DIM_SENSOR_GROUP_CHENJIANG> T_DIM_SENSOR_GROUP_CHENJIANG { get; set; }
        public virtual ICollection<T_DIM_SENSOR_GROUP_JINRUNXIAN> T_DIM_SENSOR_GROUP_JINRUNXIAN { get; set; }
        public virtual T_DIM_GROUP_TYPE T_DIM_GROUP_TYPE { get; set; }
        public virtual ICollection<T_DIM_SENSOR_GROUP_CEXIE> T_DIM_SENSOR_GROUP_CEXIE { get; set; }
    }
}
