﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace genero_API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PringlesDBEntities : DbContext
    {
        public PringlesDBEntities()
            : base("name=PringlesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<AutorLibro> AutorLibro { get; set; }
        public virtual DbSet<Caja> Caja { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Criterio> Criterio { get; set; }
        public virtual DbSet<CriterioLibro> CriterioLibro { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompra { get; set; }
        public virtual DbSet<DetalleDescuento> DetalleDescuento { get; set; }
        public virtual DbSet<DetalleOrden> DetalleOrden { get; set; }
        public virtual DbSet<DireccionCliente> DireccionCliente { get; set; }
        public virtual DbSet<EmailCliente> EmailCliente { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<HistorialCompraVentaLibro> HistorialCompraVentaLibro { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Orden> Orden { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<RegistroCaja> RegistroCaja { get; set; }
        public virtual DbSet<RegistroCierre> RegistroCierre { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Telefono> Telefono { get; set; }
        public virtual DbSet<TelefonoCliente> TelefonoCliente { get; set; }
        public virtual DbSet<TipoTelefono> TipoTelefono { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
