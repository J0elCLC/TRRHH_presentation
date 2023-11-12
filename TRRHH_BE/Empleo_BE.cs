using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRRHH_BE
{
    public class Empleo_BE
    {
        public int codigo_empleo {  get; set; }
        public string nombre_empleo { get; set; }
        public decimal salariominimo_empleo { get; set; }
        public decimal salariomaximo_empleo { get; set;}
        public bool activo { get; set;}
    }
}
