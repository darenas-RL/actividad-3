namespace actividad_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textnombre = new TextBox();
            grupoact = new GroupBox();
            btnlectura = new CheckBox();
            btnprogra = new CheckBox();
            btnarte = new CheckBox();
            btnmusica = new CheckBox();
            btndeportes = new CheckBox();
            grupomoda = new GroupBox();
            btnenlinea = new RadioButton();
            btnhibrida = new RadioButton();
            btnpresencial = new RadioButton();
            btnmostrar = new Button();
            btnlimpiar = new Button();
            textresumen = new TextBox();
            Resumen = new Label();
            grupoact.SuspendLayout();
            grupomoda.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 41);
            label1.Name = "label1";
            label1.Size = new Size(164, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Alumno:";
            label1.Click += label1_Click;
            // 
            // textnombre
            // 
            textnombre.Location = new Point(230, 43);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(188, 23);
            textnombre.TabIndex = 1;
            // 
            // grupoact
            // 
            grupoact.BackColor = Color.LightSteelBlue;
            grupoact.Controls.Add(btnlectura);
            grupoact.Controls.Add(btnprogra);
            grupoact.Controls.Add(btnarte);
            grupoact.Controls.Add(btnmusica);
            grupoact.Controls.Add(btndeportes);
            grupoact.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grupoact.Location = new Point(59, 107);
            grupoact.Name = "grupoact";
            grupoact.Size = new Size(294, 184);
            grupoact.TabIndex = 2;
            grupoact.TabStop = false;
            grupoact.Text = "ACTIVIDAD FAVORITAS (puedes elegir varias)";
            // 
            // btnlectura
            // 
            btnlectura.AutoSize = true;
            btnlectura.Location = new Point(20, 144);
            btnlectura.Name = "btnlectura";
            btnlectura.Size = new Size(82, 22);
            btnlectura.TabIndex = 4;
            btnlectura.Text = "LECTURA";
            btnlectura.UseVisualStyleBackColor = true;
            // 
            // btnprogra
            // 
            btnprogra.AutoSize = true;
            btnprogra.Location = new Point(20, 116);
            btnprogra.Name = "btnprogra";
            btnprogra.Size = new Size(125, 22);
            btnprogra.TabIndex = 3;
            btnprogra.Text = "PROGRAMACION";
            btnprogra.UseVisualStyleBackColor = true;
            // 
            // btnarte
            // 
            btnarte.AutoSize = true;
            btnarte.Location = new Point(20, 88);
            btnarte.Name = "btnarte";
            btnarte.Size = new Size(57, 22);
            btnarte.TabIndex = 2;
            btnarte.Text = "ARTE";
            btnarte.UseVisualStyleBackColor = true;
            // 
            // btnmusica
            // 
            btnmusica.AutoSize = true;
            btnmusica.Location = new Point(20, 60);
            btnmusica.Name = "btnmusica";
            btnmusica.Size = new Size(73, 22);
            btnmusica.TabIndex = 1;
            btnmusica.Text = "MUSICA";
            btnmusica.UseVisualStyleBackColor = true;
            // 
            // btndeportes
            // 
            btndeportes.AutoSize = true;
            btndeportes.Location = new Point(20, 32);
            btndeportes.Name = "btndeportes";
            btndeportes.Size = new Size(88, 22);
            btndeportes.TabIndex = 0;
            btndeportes.Text = "DEPORTES";
            btndeportes.UseVisualStyleBackColor = true;
            // 
            // grupomoda
            // 
            grupomoda.Controls.Add(btnenlinea);
            grupomoda.Controls.Add(btnhibrida);
            grupomoda.Controls.Add(btnpresencial);
            grupomoda.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grupomoda.Location = new Point(373, 107);
            grupomoda.Name = "grupomoda";
            grupomoda.Size = new Size(231, 187);
            grupomoda.TabIndex = 3;
            grupomoda.TabStop = false;
            grupomoda.Text = "MODALIDAD PREFERIDA (Elige una)";
            // 
            // btnenlinea
            // 
            btnenlinea.AutoSize = true;
            btnenlinea.Location = new Point(32, 126);
            btnenlinea.Name = "btnenlinea";
            btnenlinea.Size = new Size(81, 22);
            btnenlinea.TabIndex = 2;
            btnenlinea.TabStop = true;
            btnenlinea.Text = "EN LINEA";
            btnenlinea.UseVisualStyleBackColor = true;
            // 
            // btnhibrida
            // 
            btnhibrida.AutoSize = true;
            btnhibrida.Location = new Point(32, 78);
            btnhibrida.Name = "btnhibrida";
            btnhibrida.Size = new Size(75, 22);
            btnhibrida.TabIndex = 1;
            btnhibrida.TabStop = true;
            btnhibrida.Text = "HIBRIDA";
            btnhibrida.UseVisualStyleBackColor = true;
            // 
            // btnpresencial
            // 
            btnpresencial.AutoSize = true;
            btnpresencial.Location = new Point(32, 32);
            btnpresencial.Name = "btnpresencial";
            btnpresencial.Size = new Size(99, 22);
            btnpresencial.TabIndex = 0;
            btnpresencial.TabStop = true;
            btnpresencial.Text = "PRESENCIAL";
            btnpresencial.UseVisualStyleBackColor = true;
            // 
            // btnmostrar
            // 
            btnmostrar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmostrar.Location = new Point(300, 315);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(137, 23);
            btnmostrar.TabIndex = 4;
            btnmostrar.Text = "Mostrar Resumen";
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimpiar.Location = new Point(456, 315);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(90, 23);
            btnlimpiar.TabIndex = 5;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // textresumen
            // 
            textresumen.Location = new Point(79, 370);
            textresumen.Multiline = true;
            textresumen.Name = "textresumen";
            textresumen.ReadOnly = true;
            textresumen.ScrollBars = ScrollBars.Vertical;
            textresumen.Size = new Size(525, 153);
            textresumen.TabIndex = 6;
            // 
            // Resumen
            // 
            Resumen.AutoSize = true;
            Resumen.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Resumen.Location = new Point(79, 350);
            Resumen.Name = "Resumen";
            Resumen.Size = new Size(72, 17);
            Resumen.TabIndex = 7;
            Resumen.Text = "RESUMEN:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(629, 542);
            Controls.Add(Resumen);
            Controls.Add(textresumen);
            Controls.Add(btnlimpiar);
            Controls.Add(btnmostrar);
            Controls.Add(grupomoda);
            Controls.Add(grupoact);
            Controls.Add(textnombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Preferencias de actividades";
            Load += Form1_Load;
            grupoact.ResumeLayout(false);
            grupoact.PerformLayout();
            grupomoda.ResumeLayout(false);
            grupomoda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textnombre;
        private GroupBox grupoact;
        private CheckBox btnprogra;
        private CheckBox btnarte;
        private CheckBox btnmusica;
        private CheckBox btndeportes;
        private CheckBox btnlectura;
        private GroupBox grupomoda;
        private RadioButton btnenlinea;
        private RadioButton btnhibrida;
        private RadioButton btnpresencial;
        private Button btnmostrar;
        private Button btnlimpiar;
        private TextBox textresumen;
        private Label Resumen;
    }
}
