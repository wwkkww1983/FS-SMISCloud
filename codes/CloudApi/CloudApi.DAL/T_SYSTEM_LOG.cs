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
    
    public partial class T_SYSTEM_LOG
    {
        public int Id { get; set; }
        public System.DateTime RecordTime { get; set; }
        public string ProcessName { get; set; }
        public string Level { get; set; }
        public string FileName { get; set; }
        public int LineNo { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public bool IsSend { get; set; }
    }
}
