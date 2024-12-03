namespace DemoPatronConsumidor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRegistrar = new Button();
            txtCorreoElectronico = new TextBox();
            label = new Label();
            txtNombres = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnProcesar = new Button();
            dgvUsuario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            CorreoElectronico = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtCorreoElectronico);
            panel1.Controls.Add(label);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 166);
            panel1.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Lime;
            btnRegistrar.Location = new Point(323, 120);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(109, 30);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(15, 85);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(258, 23);
            txtCorreoElectronico.TabIndex = 3;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(24, 67);
            label.Name = "label";
            label.Size = new Size(108, 15);
            label.TabIndex = 2;
            label.Text = "Correo Electronico:\r\n";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(15, 38);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(258, 23);
            txtNombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(btnProcesar);
            panel2.Controls.Add(dgvUsuario);
            panel2.Location = new Point(14, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 212);
            panel2.TabIndex = 1;
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.Yellow;
            btnProcesar.Location = new Point(470, 21);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(102, 32);
            btnProcesar.TabIndex = 1;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = false;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.BackgroundColor = Color.FromArgb(255, 192, 192);
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, CorreoElectronico, Fecha });
            dgvUsuario.GridColor = Color.FromArgb(255, 192, 192);
            dgvUsuario.Location = new Point(4, 4);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.Size = new Size(434, 202);
            dgvUsuario.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // CorreoElectronico
            // 
            CorreoElectronico.HeaderText = "CorreoElectronico";
            CorreoElectronico.Name = "CorreoElectronico";
            CorreoElectronico.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(654, 435);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Demostracion patron Productor-Consumidor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtCorreoElectronico;
        private Label label;
        private TextBox txtNombres;
        private Label label1;
        private Button btnRegistrar;
        private Panel panel2;
        private DataGridView dgvUsuario;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn CorreoElectronico;
        private DataGridViewTextBoxColumn Fecha;
        private Button btnProcesar;
    }
}
