using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRRHH_BE
{
    public class Empleado
    {
        public int codigo_empleado {  get; set; }
        public string nombre_empleado { get; set; }
        public string DNI_empleado { get; set; }
        public string apellidopaterno_empleado { get; set; }
        public DateTime fechanacimiento_empleado { get; set; }
        public DateTime fechacontratacion_empleado { get; set; }
        public decimal salario_empleado { get; set; }
    }
}
