﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SeminarEntities : DbContext
    {
        public SeminarEntities()
            : base("name=SeminarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_LOGIN_CODE> T_LOGIN_CODE { get; set; }
        public virtual DbSet<T_LOGIN_DATA> T_LOGIN_DATA { get; set; }
        public virtual DbSet<T_LOGIN_QR> T_LOGIN_QR { get; set; }
        public virtual DbSet<T_USER_DV> T_USER_DV { get; set; }
        public virtual DbSet<T_USER_DATA> T_USER_DATA { get; set; }
    }
}
