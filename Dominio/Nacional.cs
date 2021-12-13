using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Nacional : Paquete
    {
       
        public Nacional(int _cuotaMax ){
            this.CuotaMaxima = _cuotaMax;
        }
        public override void insertarPaquete()
        {
            base.insertarPaquete();
           
        }
        public double SetImpuestoPorcentaje(double porcentaje)
        {
            return (PrecioBase * porcentaje) + PrecioBase;
        }

        public  override  bool  cargarPago(int cantidadCoutas,double porcentaje)
        {
            double valorPorCuota = 0;
           
            if (cantidadCoutas > 0) {
                valorPorCuota = SetImpuestoPorcentaje(porcentaje/100) / cantidadCoutas;
            }
            if (cantidadCoutas > CuotaMaxima)
                return false;
            else
            {
                this.pago = new Pago(cantidadCoutas, valorPorCuota);
                return true;
            }
            
        }
         


    }
}
