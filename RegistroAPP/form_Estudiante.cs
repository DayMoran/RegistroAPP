using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAPP
{
    public partial class form_Estudiante : Form
    {
        BindingList<Estudiante> _EstudianteList;
        public form_Estudiante()
        {
            InitializeComponent();
            _EstudianteList = new BindingList<Estudiante>();
            dataGridView1.DataSource=_EstudianteList;

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante(int.Parse(txt_id.Text), txt_nombre.Text, txt_paterno.Text,txt_materno.Text,txt_ci.Text,mtxt_celular.Text,txt_matricula.Text,chk_activo.Checked);

            MessageBox.Show("Su contraseña es:\n "+ estudiante.getPassword());
            _EstudianteList.Add(estudiante);
            limpiarCampos();
        }
        void limpiarCampos()
        {
            txt_ci.Text = "";
            txt_id.Text = "";
            txt_materno.Text = "";
            txt_paterno.Text = "";
            txt_nombre.Text = "";
            mtxt_celular.Text = "";
            txt_matricula.Text = "";
            chk_activo.Checked = false;
            
        }
    }
}
