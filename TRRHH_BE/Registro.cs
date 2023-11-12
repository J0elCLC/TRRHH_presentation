using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRRHH_BE
{
    public class Registro
    {
        public int codigo_registro { get; set; } = 0;
        public int codigo_empleado { get; set; } 
        public int codigo_area { get; set; }
        public int codigo_empleo {  get; set; }
        public DateTime fecha_registro { get; set; }
        public decimal salariomin_registro { get; set; }
        public decimal salariomax_registro { get; set; }
        public bool activo_registro { get; set; }
    }
}
