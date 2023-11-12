using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRRHH_BE;
using TRRHH_DATA;

namespace TRRHH_BL
{
    public class Empleo_BL
    {
        private readonly Empleo_data objEmpleo_data;
        public Empleo_BL()
        {
            objEmpleo_data=new Empleo_data();
        }
        public List<Empleo_BE> ListarActivas()
        {
            try
            {
                return objEmpleo_data.ListarActivas();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public decimal Buscar_salariomin(int codigo_empleo)
        {
            return objEmpleo_data.Buscar_salariomin(codigo_empleo);
        }
        public decimal Buscar_salariomax(int codigo_empleo)
        {
            return objEmpleo_data.Buscar_salariomax(codigo_empleo);
        }
    }
}
