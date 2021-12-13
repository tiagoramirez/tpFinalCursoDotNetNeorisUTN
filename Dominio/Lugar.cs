using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lugar
    {
        [Key]
        private int idLugar;
        private string pais;
        private string ciudad;
        private DateTime fechaLLegada;
        private DateTime fechaSalida;

        public Lugar(string pais, string ciudad, DateTime fechaLLegada, DateTime fechaSalida)
        {
            this.Pais = pais;
            this.Ciudad = ciudad;
            this.FechaLLegada = fechaLLegada;
            this.FechaSalida = fechaSalida;
        }

        public string Pais { get => pais; set => pais = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public DateTime FechaLLegada { get => fechaLLegada; set => fechaLLegada = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }

    }
}
