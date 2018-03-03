namespace PruebaCasa1
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
            this.BSuma = new System.Windows.Forms.Button();
            this.BResta = new System.Windows.Forms.Button();
            this.TBnum1 = new System.Windows.Forms.TextBox();
            this.TBnum2 = new System.Windows.Forms.TextBox();
            this.Lresult = new System.Windows.Forms.Label();
            this.Lcuadro1 = new System.Windows.Forms.Label();
            this.Lcuadro2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BSuma
            // 
            this.BSuma.Location = new System.Drawing.Point(22, 214);
            this.BSuma.Name = "BSuma";
            this.BSuma.Size = new System.Drawing.Size(75, 23);
            this.BSuma.TabIndex = 0;
            this.BSuma.Text = "+";
            this.BSuma.UseVisualStyleBackColor = true;
            this.BSuma.Click += new System.EventHandler(this.BSuma_Click);
            // 
            // BResta
            // 
            this.BResta.Location = new System.Drawing.Point(169, 214);
            this.BResta.Name = "BResta";
            this.BResta.Size = new System.Drawing.Size(75, 23);
            this.BResta.TabIndex = 1;
            this.BResta.Text = "-";
            this.BResta.UseVisualStyleBackColor = true;
            this.BResta.Click += new System.EventHandler(this.BResta_Click);
            // 
            // TBnum1
            // 
            this.TBnum1.Location = new System.Drawing.Point(22, 61);
            this.TBnum1.Name = "TBnum1";
            this.TBnum1.Size = new System.Drawing.Size(100, 20);
            this.TBnum1.TabIndex = 2;
            // 
            // TBnum2
            // 
            this.TBnum2.Location = new System.Drawing.Point(160, 61);
            this.TBnum2.Name = "TBnum2";
            this.TBnum2.Size = new System.Drawing.Size(100, 20);
            this.TBnum2.TabIndex = 3;
            // 
            // Lresult
            // 
            this.Lresult.AutoSize = true;
            this.Lresult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lresult.Location = new System.Drawing.Point(124, 144);
            this.Lresult.Name = "Lresult";
            this.Lresult.Size = new System.Drawing.Size(137, 31);
            this.Lresult.TabIndex = 4;
            this.Lresult.Text = "Resultado";
            // 
            // Lcuadro1
            // 
            this.Lcuadro1.AutoSize = true;
            this.Lcuadro1.Location = new System.Drawing.Point(44, 45);
            this.Lcuadro1.Name = "Lcuadro1";
            this.Lcuadro1.Size = new System.Drawing.Size(53, 13);
            this.Lcuadro1.TabIndex = 5;
            this.Lcuadro1.Text = "Numero 1";
            // 
            // Lcuadro2
            // 
            this.Lcuadro2.AutoSize = true;
            this.Lcuadro2.Location = new System.Drawing.Point(180, 45);
            this.Lcuadro2.Name = "Lcuadro2";
            this.Lcuadro2.Size = new System.Drawing.Size(53, 13);
            this.Lcuadro2.TabIndex = 6;
            this.Lcuadro2.Text = "Numero 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Lcuadro2);
            this.Controls.Add(this.Lcuadro1);
            this.Controls.Add(this.Lresult);
            this.Controls.Add(this.TBnum2);
            this.Controls.Add(this.TBnum1);
            this.Controls.Add(this.BResta);
            this.Controls.Add(this.BSuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BSuma;
        private System.Windows.Forms.Button BResta;
        private System.Windows.Forms.TextBox TBnum1;
        private System.Windows.Forms.TextBox TBnum2;
        private System.Windows.Forms.Label Lresult;
        private System.Windows.Forms.Label Lcuadro1;
        private System.Windows.Forms.Label Lcuadro2;
    }
}

