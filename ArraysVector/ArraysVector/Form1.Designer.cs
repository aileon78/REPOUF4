namespace ArraysVector
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTcargarvector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTpromedio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBXnotas = new System.Windows.Forms.ComboBox();
            this.BTsalir = new System.Windows.Forms.Button();
            this.BTnuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTcargarvector);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTnuevo);
            this.groupBox2.Controls.Add(this.BTsalir);
            this.groupBox2.Controls.Add(this.CBXnotas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TXTpromedio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // BTcargarvector
            // 
            this.BTcargarvector.Location = new System.Drawing.Point(123, 80);
            this.BTcargarvector.Name = "BTcargarvector";
            this.BTcargarvector.Size = new System.Drawing.Size(130, 49);
            this.BTcargarvector.TabIndex = 0;
            this.BTcargarvector.Text = "Cargar vector";
            this.BTcargarvector.UseVisualStyleBackColor = true;
            this.BTcargarvector.Click += new System.EventHandler(this.BTcargarvector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promedio";
            // 
            // TXTpromedio
            // 
            this.TXTpromedio.Location = new System.Drawing.Point(150, 81);
            this.TXTpromedio.Name = "TXTpromedio";
            this.TXTpromedio.Size = new System.Drawing.Size(121, 20);
            this.TXTpromedio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notas";
            // 
            // CBXnotas
            // 
            this.CBXnotas.FormattingEnabled = true;
            this.CBXnotas.Location = new System.Drawing.Point(150, 37);
            this.CBXnotas.Name = "CBXnotas";
            this.CBXnotas.Size = new System.Drawing.Size(121, 21);
            this.CBXnotas.TabIndex = 3;
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(244, 118);
            this.BTsalir.Name = "BTsalir";
            this.BTsalir.Size = new System.Drawing.Size(81, 31);
            this.BTsalir.TabIndex = 4;
            this.BTsalir.Text = "&SALIR";
            this.BTsalir.UseVisualStyleBackColor = true;
            this.BTsalir.Click += new System.EventHandler(this.BTsalir_Click);
            // 
            // BTnuevo
            // 
            this.BTnuevo.Location = new System.Drawing.Point(75, 118);
            this.BTnuevo.Name = "BTnuevo";
            this.BTnuevo.Size = new System.Drawing.Size(74, 31);
            this.BTnuevo.TabIndex = 5;
            this.BTnuevo.Text = "NUEVO";
            this.BTnuevo.UseVisualStyleBackColor = true;
            this.BTnuevo.Click += new System.EventHandler(this.BTnuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(417, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Array-Vector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTcargarvector;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTnuevo;
        private System.Windows.Forms.Button BTsalir;
        private System.Windows.Forms.ComboBox CBXnotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTpromedio;
        private System.Windows.Forms.Label label1;
    }
}

