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
    
    public partial class T_DIM_OPERATION_RESOURCE
    {
        public T_DIM_OPERATION_RESOURCE()
        {
            this.T_DIM_OPERATION_LOG = new HashSet<T_DIM_OPERATION_LOG>();
        }
    
        public byte OPERATION_RES_ID { get; set; }
        public string OPERATION_RES_FUNC_CODE { get; set; }
        public string OPERATION_RES_PARENT_CODE { get; set; }
        public string OPERATION_RES_NAME_CN { get; set; }
        public string OPERATION_RES_NAME_EN { get; set; }
        public string OPERATION_RES_ICON_SRC { get; set; }
        public string OPERATION_RES_URL { get; set; }
        public byte OPERATION_RES_ENABLE { get; set; }
    
        public virtual ICollection<T_DIM_OPERATION_LOG> T_DIM_OPERATION_LOG { get; set; }
    }
}
