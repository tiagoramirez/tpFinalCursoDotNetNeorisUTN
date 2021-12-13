namespace Dominio
{
    public interface IPago
    {
        int CantidadDeCuotas { get; set; }
        double ValorPorCuota { get; set; }

        void CargarPago();
    }
}