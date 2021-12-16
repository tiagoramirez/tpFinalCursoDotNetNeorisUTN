using Dominio;
using Controlador;

namespace Acciones
{
    public static class AccionesCliente
    {
        public static void CrearClienteParticularYSubirBd()
        {
            var nuevoCliente = new Particular();
            nuevoCliente.CargarCliente();
            ControladorCliente.AgregarBd(nuevoCliente);
        }

        public static void CrearClienteCorporativoYSubirBd()
        {
            var nuevoCliente = new Corporativo();
            nuevoCliente.CargarCliente();
            ControladorCliente.AgregarBd(nuevoCliente);
        }

    }
}