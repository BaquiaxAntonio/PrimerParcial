using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    internal class Inscripcion
    {
        string dpiEstudiante;
        string idTaller;
        DateTime fecha;

        public string DpiEstudiante { get => dpiEstudiante; set => dpiEstudiante = value; }
        public string IdTaller { get => idTaller; set => idTaller = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
