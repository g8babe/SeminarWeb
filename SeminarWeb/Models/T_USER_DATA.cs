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
    
    public partial class T_USER_DATA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_USER_DATA()
        {
            this.T_USER_DV = new HashSet<T_USER_DV>();
            this.T_LOGIN_CODE = new HashSet<T_LOGIN_CODE>();
            this.T_LOGIN_DATA = new HashSet<T_LOGIN_DATA>();
            this.T_LOGIN_QR = new HashSet<T_LOGIN_QR>();
        }
    
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Isvalid { get; set; }
        public Nullable<System.DateTime> ValidTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_USER_DV> T_USER_DV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_LOGIN_CODE> T_LOGIN_CODE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_LOGIN_DATA> T_LOGIN_DATA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_LOGIN_QR> T_LOGIN_QR { get; set; }
    }
}
