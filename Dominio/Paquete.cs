using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Paquete
    {
        private string nombre;
        private double precioBase;
        private Lugar [] listaLugares = new Lugar[10];
        private int cantidadDiasTotales;
        private DateTime fechaDeViaje;
        private bool vigente;
        private int cantidadDeCuotas;
        private double valorPorCuota;

        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public int CantidadDiasTotales { get => cantidadDiasTotales; set => cantidadDiasTotales = value; }
        public DateTime FechaDeViaje { get => fechaDeViaje; set => fechaDeViaje = value; }
        public bool Vigente { get => vigente; set => vigente = value; }
        public int CantidadDeCuotas { get => cantidadDeCuotas; set => cantidadDeCuotas = value; }
        public double ValorPorCuota { get => valorPorCuota; set => valorPorCuota = value; }
        internal Lugar[] ListaLugares { get => listaLugares; set => listaLugares = value; }

        public Paquete(string nombre, double precioBase, Lugar[] listaLugares, int cantidadDiasTotales, DateTime fechaDeViaje, bool vigente, int cantidadDeCuotas, double valorPorCuota)
        {
            this.nombre = nombre;
            this.precioBase = precioBase;
            this.listaLugares = listaLugares;
            this.cantidadDiasTotales = cantidadDiasTotales;
            this.fechaDeViaje = fechaDeViaje;
            this.vigente = vigente;
            this.cantidadDeCuotas = cantidadDeCuotas;
            this.valorPorCuota = valorPorCuota;
        }

    }
}
