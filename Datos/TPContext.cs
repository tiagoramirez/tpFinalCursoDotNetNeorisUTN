using System.Data.Entity;
using Dominio;

namespace Datos
{
    public class TPContext:DbContext
    {
        public TPContext() : base("TPContext")
        { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
    }
}
