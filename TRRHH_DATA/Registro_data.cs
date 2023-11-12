using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRRHH_BE;
using TRRHH_EF;

namespace TRRHH_DATA
{
    public class Registro_data
    {
        private readonly db_TRRHHEntities db;

        public Registro_data()
        {
            db = new db_TRRHHEntities();
        }

        public int Registrar(Registro objResgitroBE)
        {
            var objResgitro = new Registro
            {
                codigo_empleado = objResgitroBE.codigo_empleado,
                codigo_empleo = objResgitroBE.codigo_empleo,
                fecha_registro = DateTime.Now,
                salariomin_registro = objResgitroBE.salariomin_registro,
                salariomax_registro= objResgitroBE.salariomax_registro,
                activo_registro = true
            };

            db.TEmpleos.Add(objResgitro);
            db.SaveChanges();

            return objResgitro.codigo_registro;
        }

        public bool Modificar(Registro objResgitroBE)
        {
            var objReserva_Actualizar = db.TEmpleos.ToList().Find(x => x.codigo.Equals(objResgitroBE.codigo_registro));
            objReserva_Actualizar.salario_minimo = objResgitroBE.salario_minimo;
            objReserva_Actualizar.salario_maximo = objResgitroBE.salario_maximo;
            objReserva_Actualizar. fecha_registro= DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool Eliminar(int codigo_registro)
        {
            db.TEmpleos.Remove(db.TEmpleos.ToList().Find(x => x.codigo.Equals(codigo_registro)));
            db.SaveChanges();

            return true;
        }

        public Registro BuscarPorId(int codigo_registro)
        {
            var objResgitro = db.codigo_registro.ToList().Find(x => x.codigo_registro.Equals(codigo_registro));

            var objResgitroBE = new Registro
            {
                codigo_registro = objResgitro.codigo_registro,
                codigo_empleado = objResgitro.codigo_empleado,
                codigo_empleo = objResgitro.codigo_empleo,
                codigo_area = objResgitro.codigo_area,
                salariomax_registro = objResgitro.salariomax_registro,
                salariomin_registro = objResgitro.salariomin_registro,
                activo_registro = objResgitro.activo_registro
            };

            return objResgitroBE;
        }

        public List<Registro> ListarPorCliente(int codigo_registro)
        {
            var query = from res in db.TEmpleos
                        where res.codigo.Equals(codigo_registro) && res.activo
                        select new Registro 
                        {
                            codigo_registro = res.codigo_registro,
                            salariomax_registro = res.salariomax_registro,
                            salariomin_registro = res.salariomin_registro
                        };

            return query.ToList();
        }
    }
}
}
