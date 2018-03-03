namespace _300_HolaMundo
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
            this.RTText = new System.Windows.Forms.RichTextBox();
            this.BOK = new System.Windows.Forms.Button();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RTText
            // 
            this.RTText.BackColor = System.Drawing.SystemColors.Control;
            this.RTText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTText.Location = new System.Drawing.Point(195, 23);
            this.RTText.Name = "RTText";
            this.RTText.ReadOnly = true;
            this.RTText.Size = new System.Drawing.Size(171, 189);
            this.RTText.TabIndex = 0;
            this.RTText.Text = "";
            // 
            // BOK
            // 
            this.BOK.Location = new System.Drawing.Point(24, 129);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(88, 62);
            this.BOK.TabIndex = 1;
            this.BOK.Text = "&Ok";
            this.BOK.UseVisualStyleBackColor = true;
            this.BOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(24, 39);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(143, 20);
            this.TBNom.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 350);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.BOK);
            this.Controls.Add(this.RTText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTText;
        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.TextBox TBNom;
    }
}

