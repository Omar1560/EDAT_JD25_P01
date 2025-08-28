namespace UI.NumerosAleatorios
{
    partial class frmDatosAleatorios
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
            btnMostrarMensaje = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            Numero = new MaskedTextBox();
            Nombre = new MaskedTextBox();
            Masculino = new CheckBox();
            Femenino = new CheckBox();
            Sueldo = new MaskedTextBox();
            Grupo = new ComboBox();
            Seguro = new CheckBox();
            Dia = new MaskedTextBox();
            Mes = new MaskedTextBox();
            Año = new MaskedTextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnMostrarMensaje
            // 
            btnMostrarMensaje.BackColor = SystemColors.ControlDark;
            btnMostrarMensaje.ForeColor = SystemColors.ControlText;
            btnMostrarMensaje.Location = new Point(58, 459);
            btnMostrarMensaje.Name = "btnMostrarMensaje";
            btnMostrarMensaje.Size = new Size(370, 23);
            btnMostrarMensaje.TabIndex = 0;
            btnMostrarMensaje.Text = "Generar Datos Aleatorios";
            btnMostrarMensaje.UseVisualStyleBackColor = false;
            btnMostrarMensaje.Click += btnMostrarMensaje_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "Datos del Empleado";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 95);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 142);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 194);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 305);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 8;
            label8.Text = "Grupo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 340);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 9;
            label9.Text = "Sueldo";
            label9.Click += label9_Click;
            // 
            // Numero
            // 
            Numero.Location = new Point(105, 92);
            Numero.Name = "Numero";
            Numero.Size = new Size(100, 23);
            Numero.TabIndex = 10;
            Numero.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(105, 134);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(137, 23);
            Nombre.TabIndex = 11;
            // 
            // Masculino
            // 
            Masculino.AutoSize = true;
            Masculino.Location = new Point(72, 243);
            Masculino.Name = "Masculino";
            Masculino.Size = new Size(81, 19);
            Masculino.TabIndex = 12;
            Masculino.Text = "Masculino";
            Masculino.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            Femenino.AutoSize = true;
            Femenino.Location = new Point(72, 273);
            Femenino.Name = "Femenino";
            Femenino.Size = new Size(79, 19);
            Femenino.TabIndex = 13;
            Femenino.Text = "Femenino";
            Femenino.UseVisualStyleBackColor = true;
            // 
            // Sueldo
            // 
            Sueldo.Location = new Point(105, 337);
            Sueldo.Name = "Sueldo";
            Sueldo.Size = new Size(100, 23);
            Sueldo.TabIndex = 16;
            // 
            // Grupo
            // 
            Grupo.FormattingEnabled = true;
            Grupo.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            Grupo.Location = new Point(104, 302);
            Grupo.Name = "Grupo";
            Grupo.Size = new Size(121, 23);
            Grupo.TabIndex = 17;
            // 
            // Seguro
            // 
            Seguro.AutoSize = true;
            Seguro.Location = new Point(99, 395);
            Seguro.Name = "Seguro";
            Seguro.Size = new Size(106, 19);
            Seguro.TabIndex = 18;
            Seguro.Text = "Seguro Medico";
            Seguro.UseVisualStyleBackColor = true;
            // 
            // Dia
            // 
            Dia.Location = new Point(172, 191);
            Dia.Name = "Dia";
            Dia.Size = new Size(18, 23);
            Dia.TabIndex = 19;
            // 
            // Mes
            // 
            Mes.Location = new Point(196, 191);
            Mes.Name = "Mes";
            Mes.Size = new Size(20, 23);
            Mes.TabIndex = 20;
            // 
            // Año
            // 
            Año.Location = new Point(222, 191);
            Año.Name = "Año";
            Año.Size = new Size(54, 23);
            Año.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 173);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 22;
            label5.Text = "Dia / Mes / Año";
            label5.Click += label5_Click;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 523);
            Controls.Add(label5);
            Controls.Add(Año);
            Controls.Add(Mes);
            Controls.Add(Dia);
            Controls.Add(Seguro);
            Controls.Add(Grupo);
            Controls.Add(Sueldo);
            Controls.Add(Femenino);
            Controls.Add(Masculino);
            Controls.Add(Nombre);
            Controls.Add(Numero);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMostrarMensaje);
            Name = "frmDatosAleatorios";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnMostrarMensaje;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label9;
        private MaskedTextBox Numero;
        private MaskedTextBox Nombre;
        private CheckBox Masculino;
        private CheckBox Femenino;
        private MaskedTextBox Sueldo;
        private ComboBox Grupo;
        private CheckBox Seguro;
        private MaskedTextBox Dia;
        private MaskedTextBox Mes;
        private MaskedTextBox Año;
        private Label label5;
    }
}
