namespace RegistroAPP
{
    partial class form_Estudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxt_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_activo = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_registrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.btn_registrar.Location = new System.Drawing.Point(96, 357);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(100, 42);
            this.btn_registrar.TabIndex = 1;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(96, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(96, 67);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txt_paterno
            // 
            this.txt_paterno.Location = new System.Drawing.Point(96, 108);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(100, 23);
            this.txt_paterno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paterno:";
            // 
            // txt_materno
            // 
            this.txt_materno.Location = new System.Drawing.Point(96, 149);
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(100, 23);
            this.txt_materno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label4.Location = new System.Drawing.Point(25, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Materno:";
            // 
            // txt_ci
            // 
            this.txt_ci.Location = new System.Drawing.Point(96, 190);
            this.txt_ci.Name = "txt_ci";
            this.txt_ci.Size = new System.Drawing.Size(100, 23);
            this.txt_ci.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label5.Location = new System.Drawing.Point(25, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "C.I.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label6.Location = new System.Drawing.Point(25, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Celular:";
            // 
            // mtxt_celular
            // 
            this.mtxt_celular.Location = new System.Drawing.Point(96, 231);
            this.mtxt_celular.Mask = "99999999";
            this.mtxt_celular.Name = "mtxt_celular";
            this.mtxt_celular.Size = new System.Drawing.Size(100, 23);
            this.mtxt_celular.TabIndex = 12;
            this.mtxt_celular.ValidatingType = typeof(int);
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(96, 272);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 23);
            this.txt_matricula.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label7.Location = new System.Drawing.Point(25, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Matricula:";
            // 
            // chk_activo
            // 
            this.chk_activo.AutoSize = true;
            this.chk_activo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_activo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.chk_activo.Location = new System.Drawing.Point(96, 317);
            this.chk_activo.Name = "chk_activo";
            this.chk_activo.Size = new System.Drawing.Size(62, 19);
            this.chk_activo.TabIndex = 15;
            this.chk_activo.Text = "Activo";
            this.chk_activo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(241, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(846, 373);
            this.dataGridView1.TabIndex = 16;
            // 
            // form_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1099, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chk_activo);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxt_celular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_materno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_paterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label1);
            this.Name = "form_Estudiante";
            this.Text = "form_Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_registrar;
        private TextBox txt_id;
        private TextBox txt_nombre;
        private Label label2;
        private TextBox txt_paterno;
        private Label label3;
        private TextBox txt_materno;
        private Label label4;
        private TextBox txt_ci;
        private Label label5;
        private Label label6;
        private MaskedTextBox mtxt_celular;
        private TextBox txt_matricula;
        private Label label7;
        private CheckBox chk_activo;
        private DataGridView dataGridView1;
    }
}