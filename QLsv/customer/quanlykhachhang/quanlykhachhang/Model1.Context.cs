﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace quanlykhachhang
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class danhbaEntities : DbContext
    {
        public danhbaEntities()
            : base("name=danhbaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dangnhap> dangnhaps { get; set; }
        public virtual DbSet<khachhang> khachhangs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<thongtincanhan> thongtincanhans { get; set; }
        public virtual DbSet<thongtinnhanvien> thongtinnhanviens { get; set; }
    
        public virtual ObjectResult<getallkhachhang_Result> getallkhachhang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getallkhachhang_Result>("getallkhachhang");
        }
    }
}