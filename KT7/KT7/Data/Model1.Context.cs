﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KT7.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KT7_Stepanyan_georgyyEntities : DbContext
    {
        public static KT7_Stepanyan_georgyyEntities _context;
        public KT7_Stepanyan_georgyyEntities()
            : base("name=KT7_Stepanyan_georgyyEntities")
        {
        }

        public static KT7_Stepanyan_georgyyEntities GetContext()
        {
            if(_context == null)
            {
                _context = new KT7_Stepanyan_georgyyEntities();
            }
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adress> Adress { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Director> Director { get; set; }
        public virtual DbSet<MasterProductImport> MasterProductImport { get; set; }
        public virtual DbSet<MaterialTypeProduct> MaterialTypeProduct { get; set; }
        public virtual DbSet<Oblast> Oblast { get; set; }
        public virtual DbSet<PartnerImport> PartnerImport { get; set; }
        public virtual DbSet<PartnerName> PartnerName { get; set; }
        public virtual DbSet<PartnerType> PartnerType { get; set; }
        public virtual DbSet<Production> Production { get; set; }
        public virtual DbSet<ProductsImport> ProductsImport { get; set; }
        public virtual DbSet<ProductTypeImport> ProductTypeImport { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Town> Town { get; set; }
        public virtual DbSet<TypeProduct> TypeProduct { get; set; }
    }
}
