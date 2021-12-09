﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Paquete
    {
        [Key]
        public  int idPaquete { get   ; set ; }
        private string nombre;
        private double precioBase;
        private Lugar[] listaLugares = new Lugar[10];
        private int cantidadDiasTotales;
        private DateTime fechaDeViaje;
        private bool vigente;
        private Pago pago=null;

        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public int CantidadDiasTotales { get => cantidadDiasTotales; set => cantidadDiasTotales = value; }
        public DateTime FechaDeViaje { get => fechaDeViaje; set => fechaDeViaje = value; }
        public bool Vigente { get => vigente; set => vigente = value; }
         
        public  Lugar[] ListaLugares { get => listaLugares; set => listaLugares = value; }
        protected abstract bool cargarPago(int cantidadDeCuotas, double valorPorCuota);
        public Paquete(string nombre, double precioBase, Lugar[] listaLugares, int cantidadDiasTotales, DateTime fechaDeViaje, bool vigente )
        {
            Console.Write("Ingresar el nombre del paquete: ");
            this.nombre = Console.ReadLine();
            Console.Clear();

            Console.Write("Ingresar el precio base del paquete: ");
            Double.TryParse(Console.ReadLine(), out this.precioBase);  
            Console.Clear();
            
            Console.Write("Ingrese los lugares que va a visitar  ");
            this.cantidadDiasTotales = cantidadDiasTotales;
            this.fechaDeViaje = fechaDeViaje;
            this.vigente = vigente;
         
        }
        public void crearPaquete()
        {

        }

    }
}
