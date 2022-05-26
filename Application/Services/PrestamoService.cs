using Application.Enums;
using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PrestamoService
    {
        public PrestamoService() { }

        public double CalcularPrestamo(PrestamoViewModel Pvm)
        {
            switch (Pvm.TipoPrestamo)
            {
                case (int)Tipo_Prestamo.PERSONAL: return CuotaMensual(Pvm);

                case (int)Tipo_Prestamo.AUTOMOVIL: return CuotaMensual(Pvm);

                case (int)Tipo_Prestamo.HIPOTECARIO: return CuotaMensual(Pvm);

                default:
                    break;
            }
            return 0;
        }
        private double CuotaMensual(PrestamoViewModel Pvm)
        {
            try
            {
                double monto = double.Parse(Pvm.Monto);
                double interes = 0;
                double prestamo = 0;
                int tasa = Convert.ToInt16(Pvm.TasaInteres);

                interes = (monto * tasa) / 100;
                prestamo = (monto + interes) / Pvm.Meses;
                return Math.Round(prestamo, 2, MidpointRounding.AwayFromZero);
            }
            catch (Exception)
            {
                return 0;
                throw;
            }

        }
    }
}
