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
    
    public partial class T_DIM_MENU_ACTION
    {
        public int ID { get; set; }
        public int MENU_ID { get; set; }
        public int ACTION_ID { get; set; }
    
        public virtual T_DIM_ACTION T_DIM_ACTION { get; set; }
        public virtual T_DIM_MENU T_DIM_MENU { get; set; }
    }
}
