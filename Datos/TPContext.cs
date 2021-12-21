using System.Data.Entity;
using Dominio;
using System;
namespace Datos
{
    public class TPContext:DbContext
    {
        public TPContext() : base("TPContext")
        { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
        public DbSet<Lugar> Lugares { get; set; }
        public DbSet<Factura> Facturas { get; set; }

    }
}
