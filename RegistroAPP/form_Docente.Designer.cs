namespace RegistroAPP
{
    partial class form_Docente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk_disponible = new System.Windows.Forms.CheckBox();
            this.mtxt_celular = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxt_sueldo = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.spn_categoria = new System.Windows.Forms.NumericUpDown();
            this.mtxt_rda = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spn_categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 444);
            this.dataGridView1.TabIndex = 33;
            // 
            // chk_disponible
            // 
            this.chk_disponible.AutoSize = true;
            this.chk_disponible.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_disponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.chk_disponible.Location = new System.Drawing.Point(97, 400);
            this.chk_disponible.Name = "chk_disponible";
            this.chk_disponible.Size = new System.Drawing.Size(84, 19);
            this.chk_disponible.TabIndex = 32;
            this.chk_disponible.Text = "Disponible";
            this.chk_disponible.UseVisualStyleBackColor = true;
            // 
            // mtxt_celular
            // 
            this.mtxt_celular.Location = new System.Drawing.Point(97, 231);
            this.mtxt_celular.Mask = "99999999";
            this.mtxt_celular.Name = "mtxt_celular";
            this.mtxt_celular.Size = new System.Drawing.Size(100, 23);
            this.mtxt_celular.TabIndex = 29;
            this.mtxt_celular.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label6.Location = new System.Drawing.Point(26, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Celular:";
            // 
            // txt_ci
            // 
            this.txt_ci.Location = new System.Drawing.Point(97, 190);
            this.txt_ci.Name = "txt_ci";
            this.txt_ci.Size = new System.Drawing.Size(100, 23);
            this.txt_ci.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label5.Location = new System.Drawing.Point(26, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "C.I.:";
            // 
            // txt_materno
            // 
            this.txt_materno.Location = new System.Drawing.Point(97, 149);
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(100, 23);
            this.txt_materno.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label4.Location = new System.Drawing.Point(26, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Materno:";
            // 
            // txt_paterno
            // 
            this.txt_paterno.Location = new System.Drawing.Point(97, 108);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(100, 23);
            this.txt_paterno.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Paterno:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(97, 67);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(97, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 19;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_registrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.btn_registrar.Location = new System.Drawing.Point(93, 437);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(104, 34);
            this.btn_registrar.TabIndex = 18;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label7.Location = new System.Drawing.Point(26, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "RDA:";
            // 
            // mtxt_sueldo
            // 
            this.mtxt_sueldo.Location = new System.Drawing.Point(97, 314);
            this.mtxt_sueldo.Mask = "###9.##";
            this.mtxt_sueldo.Name = "mtxt_sueldo";
            this.mtxt_sueldo.Size = new System.Drawing.Size(100, 23);
            this.mtxt_sueldo.TabIndex = 35;
            this.mtxt_sueldo.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label8.Location = new System.Drawing.Point(26, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Sueldo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.label9.Location = new System.Drawing.Point(26, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "Categoria:";
            // 
            // spn_categoria
            // 
            this.spn_categoria.Location = new System.Drawing.Point(93, 360);
            this.spn_categoria.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spn_categoria.Name = "spn_categoria";
            this.spn_categoria.Size = new System.Drawing.Size(104, 23);
            this.spn_categoria.TabIndex = 37;
            this.spn_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxt_rda
            // 
            this.mtxt_rda.Location = new System.Drawing.Point(97, 268);
            this.mtxt_rda.Mask = "#########9";
            this.mtxt_rda.Name = "mtxt_rda";
            this.mtxt_rda.Size = new System.Drawing.Size(100, 23);
            this.mtxt_rda.TabIndex = 38;
            this.mtxt_rda.ValidatingType = typeof(int);
            // 
            // form_Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1284, 482);
            this.Controls.Add(this.mtxt_rda);
            this.Controls.Add(this.spn_categoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mtxt_sueldo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chk_disponible);
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
            this.Name = "form_Docente";
            this.Text = "form_Docente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spn_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private CheckBox chk_disponible;
        private MaskedTextBox mtxt_celular;
        private Label label6;
        private TextBox txt_ci;
        private Label label5;
        private TextBox txt_materno;
        private Label label4;
        private TextBox txt_paterno;
        private Label label3;
        private TextBox txt_nombre;
        private Label label2;
        private TextBox txt_id;
        private Button btn_registrar;
        private Label label1;
        private Label label7;
        private MaskedTextBox mtxt_sueldo;
        private Label label8;
        private Label label9;
        private NumericUpDown spn_categoria;
        private MaskedTextBox mtxt_rda;
    }
}