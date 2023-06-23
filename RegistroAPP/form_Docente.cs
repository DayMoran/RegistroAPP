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
    public partial class form_Docente : Form
    {
        BindingList<Docente> listadocentes;
        public form_Docente()
        {
            InitializeComponent();
            listadocentes = new BindingList<Docente>();
            dataGridView1.DataSource=listadocentes;
            
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente(int.Parse(txt_id.Text), txt_nombre.Text, 
                txt_paterno.Text, txt_materno.Text, txt_ci.Text, mtxt_celular.Text, 
                mtxt_rda.Text,chk_disponible.Checked, decimal.Parse(mtxt_sueldo.Text), 
                Convert.ToInt32(spn_categoria.Value));

            MessageBox.Show("Su contraseña es:\n " + docente.getPassword());
            listadocentes.Add(docente);
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
            mtxt_rda.Text = "";
            mtxt_sueldo.Text = "";
            chk_disponible.Checked = false;
            spn_categoria.Value = 0;
        }
    }
}
