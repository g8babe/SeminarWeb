//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeminarWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_LOGIN_DATA
    {
        public string UserID { get; set; }
        public string IMEI { get; set; }
        public System.DateTime LoginTime { get; set; }
        public string LoginWeb { get; set; }
    
        public virtual T_USER_DATA T_USER_DATA { get; set; }
    }
}
