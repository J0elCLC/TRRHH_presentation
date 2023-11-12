using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TRRHH_BE;
using TRRHH_DATA;

namespace TRRHH_BL
{
    public class Registro_BL
    {
        private readonly Registro_data objRegistroDAta;

        public Registro_BL()
        {
            objRegistroDAta = new Registro_data();
        }

        public int Registrar(Registro objRegistroBE)
        {
            return objRegistroDAta.Registrar(objRegistroBE);
        }

        public List<Registro> ListarPorempeleado(int codigo_registro)
        {
            return objRegistroDAta.ListarPorempeleado(codigo_registro);
        }

        public Registro BuscarPorId(int codgio_registro)
        {
            return objRegistroDAta.BuscarPorId(codigo_registro);
        }

        public bool Modificar(Registro objRegistroBE)
        {
            return objRegistroDAta.Modificar(objRegistroBE);
        }
    }
}
}
