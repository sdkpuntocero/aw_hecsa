﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aw_hecsa
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_hecsaEntities : DbContext
    {
        public db_hecsaEntities()
            : base("name=db_hecsaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<fact_estatus> fact_estatus { get; set; }
        public virtual DbSet<fact_tipo_rfc> fact_tipo_rfc { get; set; }
        public virtual DbSet<fact_tipo_usuario> fact_tipo_usuario { get; set; }
        public virtual DbSet<inf_clientes> inf_clientes { get; set; }
        public virtual DbSet<inf_contacto_cliente> inf_contacto_cliente { get; set; }
        public virtual DbSet<inf_contacto_proveedor> inf_contacto_proveedor { get; set; }
        public virtual DbSet<inf_contribuyentes> inf_contribuyentes { get; set; }
        public virtual DbSet<inf_empresa> inf_empresa { get; set; }
        public virtual DbSet<inf_proveedores> inf_proveedores { get; set; }
        public virtual DbSet<inf_sepomex> inf_sepomex { get; set; }
        public virtual DbSet<inf_usuarios> inf_usuarios { get; set; }
        public virtual DbSet<inf_contacto_contribuyente> inf_contacto_contribuyente { get; set; }
    }
}
