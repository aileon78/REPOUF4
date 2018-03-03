namespace AlumnoArray
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido1 = new System.Windows.Forms.TextBox();
            this.TBApellido2 = new System.Windows.Forms.TextBox();
            this.CBEdad = new System.Windows.Forms.ComboBox();
            this.CBNota = new System.Windows.Forms.ComboBox();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(147, 23);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 5;
            // 
            // TBApellido1
            // 
            this.TBApellido1.Location = new System.Drawing.Point(147, 56);
            this.TBApellido1.Name = "TBApellido1";
            this.TBApellido1.Size = new System.Drawing.Size(100, 20);
            this.TBApellido1.TabIndex = 6;
            // 
            // TBApellido2
            // 
            this.TBApellido2.Location = new System.Drawing.Point(147, 94);
            this.TBApellido2.Name = "TBApellido2";
            this.TBApellido2.Size = new System.Drawing.Size(100, 20);
            this.TBApellido2.TabIndex = 7;
            // 
            // CBEdad
            // 
            this.CBEdad.FormattingEnabled = true;
            this.CBEdad.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.CBEdad.Location = new System.Drawing.Point(147, 133);
            this.CBEdad.Name = "CBEdad";
            this.CBEdad.Size = new System.Drawing.Size(47, 21);
            this.CBEdad.TabIndex = 8;
            // 
            // CBNota
            // 
            this.CBNota.FormattingEnabled = true;
            this.CBNota.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CBNota.Location = new System.Drawing.Point(147, 176);
            this.CBNota.Name = "CBNota";
            this.CBNota.Size = new System.Drawing.Size(47, 21);
            this.CBNota.TabIndex = 9;
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(318, 23);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(198, 174);
            this.RTB1.TabIndex = 10;
            this.RTB1.Text = "";
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(94, 235);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 11;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BMostrar
            // 
            this.BMostrar.Location = new System.Drawing.Point(385, 235);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(75, 23);
            this.BMostrar.TabIndex = 12;
            this.BMostrar.Text = "Mostrar";
            this.BMostrar.UseVisualStyleBackColor = true;
            this.BMostrar.Click += new System.EventHandler(this.BMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 273);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.RTB1);
            this.Controls.Add(this.CBNota);
            this.Controls.Add(this.CBEdad);
            this.Controls.Add(this.TBApellido2);
            this.Controls.Add(this.TBApellido1);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido1;
        private System.Windows.Forms.TextBox TBApellido2;
        private System.Windows.Forms.ComboBox CBEdad;
        private System.Windows.Forms.ComboBox CBNota;
        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BMostrar;
    }
}

