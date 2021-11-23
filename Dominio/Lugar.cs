using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Lugar
    {
        private string nombre;
        private DateTime fechahoraLLegada;
        private DateTime fechahoraSalida;

        public Lugar(string nombre, DateTime fechahoraLLegada, DateTime fechahoraSalida)
        {
            this.nombre = nombre;
            this.fechahoraLLegada = fechahoraLLegada;
            this.fechahoraSalida = fechahoraSalida;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechahoraLLegada { get => fechahoraLLegada; set => fechahoraLLegada = value; }
        public DateTime FechahoraSalida { get => fechahoraSalida; set => fechahoraSalida = value; }
    }
}
