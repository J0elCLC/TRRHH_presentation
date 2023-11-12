using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRRHH_BE
{
    public class Historial_empleo
    {
        public int codigo_empleo {  get; set; }
        public int codigo_empleado {  get; set; }
        public int codigo_area { get; set; }
        public DateTime fechainicio_historial { get; set; }
        public DateTime fechafin_historial { get; set; }
        public bool activo_historial { get; set; }
    }
}
