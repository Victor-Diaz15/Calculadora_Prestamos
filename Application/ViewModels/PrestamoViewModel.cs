using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class PrestamoViewModel
    {
        public string Monto { get; set; }
        public int TipoPrestamo { get; set; }
        public string TasaInteres { get; set; }
        public int Meses { get; set; }
        public double resultado { get; set; }
    }
}
