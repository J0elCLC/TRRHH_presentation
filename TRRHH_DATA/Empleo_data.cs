using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRRHH_EF;
using TRRHH_BE;

namespace TRRHH_DATA
{
    public class Empleo_data
    {
        private readonly db_TRRHHEntities context;
        public Empleo_data()
        {
            context = new db_TRRHHEntities();
        }

        public List<Empleo_BE> ListarActivas() {
        var query = (from can in context.TEmpleos
                     where can.activo.Equals(true)
                      select new Empleo_BE
                      {
                          codigo_empleo = can.codigo,
                          nombre_empleo = can.nombre
                      }).ToList();
            return query;
        }
        public decimal Buscar_salariomin(int codigo_empleo)
        {
            var query = from can in context.TEmpleos
                        where can.codigo.Equals(codigo_empleo)
                        select can.salario_minimo;

            return query.SingleOrDefault();
        }
        public decimal Buscar_salariomax(int codigo_empleo)
        {
            var query = from can in context.TEmpleos
                        where can.codigo.Equals(codigo_empleo)
                        select can.salario_minimo;

            return query.SingleOrDefault();
        }
    }
}
