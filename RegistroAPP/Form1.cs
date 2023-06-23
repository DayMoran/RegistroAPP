namespace RegistroAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_docente_Click(object sender, EventArgs e)
        {
            form_Docente form_Docente = new form_Docente();
            form_Docente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_Estudiante form_Estudiante = new form_Estudiante();
            form_Estudiante.Show();
        }
    }
}