using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    internal class Alumno
    {
        string nombre;
        string dpi;
        string direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Dpi { get => dpi; set => dpi = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
