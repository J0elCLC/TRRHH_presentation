using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TRRHH_presentation
{
    public partial class Registro : Form
    {
        private readonly int codigo_registro;
        private readonly bool modificar;
        public Registro(bool modificar, int codigo_registro=0)
        {
            InitializeComponent();
            CargarDatosregistro();
            dataGridView1.Value = DateTime.Now;

            if (modificar)
            {
                this.codigo_registro = codigo_registro;
                this.modificar = modificar;
                CargarDatosregistro();
            }
        }

        private void CargarDatosregistro()
        {
            var objRegistroBL = new Regitro_BL();
            var objRegistroBE = objRegistroBL.BuscarPorId(this.codigo_registro);
            comboBox1.SelectedValue = objRegistroBE.id_cancha;
            textBox2.text = objRegistroBE.nombre_registro;
            textBox1.Text = objRegistroBE.salariomin_registro.ToString();
            textBox2.Text = objRegistroBE.salariomax_registro.ToString();
            button1.Text = "Guardar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var objRegistroBL = new RegistroBL();
            var objRegistro = new RegistroBE
            {
                salariomin_registro = int.Parse(textBox2.Text),
                salariomax_registro = int.Parse(textBox3.Text),
                activo_registro = true
            };
            if (modificar)
            {
                objRegistro.codigo_registro = this.codigo_registro;
                objRegistro.Modificar(objRegistro);
            }
            else
            {
                objRegistroBL.Registrar(objRegistro);
            }

            Close();
        }
        private void cbRegistroEmpleo(object sender, EventArgs e)
        {
            var codgio_registro = ((Registro)comboBox1.SelectedItem).codigo_registro;
            CargarDatosregistro(codigo_empleo, dataGridView1.Value.Date);
            CargarDatosregistro(codig_registro);
        }

        private void Datagriedbiew(object sender, EventArgs e)
        {
            var codigo_registro = ((Registro)comboBox1.SelectedItem).codigo_empleo;
            CargarDatosregistro(codigo_registro, dataGridView1.Value.Date);
            CargarDatosregistro(codigo_registro);
        }
    }
}
