using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    internal class Taller
    {
        string codigoTaller;
        string nombreTaller;
        int costo;

        public string CodigoTaller { get => codigoTaller; set => codigoTaller = value; }
        public string NombreTaller { get => nombreTaller; set => nombreTaller = value; }
        public int Costo { get => costo; set => costo = value; }
    }
}
