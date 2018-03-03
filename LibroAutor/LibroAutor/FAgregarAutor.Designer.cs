namespace LibroAutor
{
    partial class FAgregarAutor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBEdad = new System.Windows.Forms.TextBox();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.BTVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(176, 33);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 3;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(176, 84);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(100, 20);
            this.TBApellido.TabIndex = 4;
            // 
            // TBEdad
            // 
            this.TBEdad.Location = new System.Drawing.Point(176, 141);
            this.TBEdad.Name = "TBEdad";
            this.TBEdad.Size = new System.Drawing.Size(100, 20);
            this.TBEdad.TabIndex = 5;
            // 
            // BTGuardar
            // 
            this.BTGuardar.Location = new System.Drawing.Point(34, 220);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTGuardar.TabIndex = 6;
            this.BTGuardar.Text = "&Guardar";
            this.BTGuardar.UseVisualStyleBackColor = true;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // BTVolver
            // 
            this.BTVolver.Location = new System.Drawing.Point(201, 220);
            this.BTVolver.Name = "BTVolver";
            this.BTVolver.Size = new System.Drawing.Size(75, 23);
            this.BTVolver.TabIndex = 7;
            this.BTVolver.Text = "&Volver";
            this.BTVolver.UseVisualStyleBackColor = true;
            this.BTVolver.Click += new System.EventHandler(this.BTVolver_Click);
            // 
            // AgregarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 300);
            this.Controls.Add(this.BTVolver);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.TBEdad);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarAutor";
            this.Text = "AgregarAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBEdad;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.Button BTVolver;
    }
}