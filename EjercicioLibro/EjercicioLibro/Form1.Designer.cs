namespace EjercicioLibro
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
            this.BTizqu = new System.Windows.Forms.Button();
            this.BTdere = new System.Windows.Forms.Button();
            this.TBtitol = new System.Windows.Forms.TextBox();
            this.TBnumpag = new System.Windows.Forms.TextBox();
            this.TBautor = new System.Windows.Forms.TextBox();
            this.TBcolorPort = new System.Windows.Forms.TextBox();
            this.TBdim = new System.Windows.Forms.TextBox();
            this.TBcont = new System.Windows.Forms.TextBox();
            this.LBtitulo = new System.Windows.Forms.Label();
            this.LBnumpag = new System.Windows.Forms.Label();
            this.LBautor = new System.Windows.Forms.Label();
            this.LBcolorport = new System.Windows.Forms.Label();
            this.LBdim = new System.Windows.Forms.Label();
            this.LBcont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTizqu
            // 
            this.BTizqu.Location = new System.Drawing.Point(12, 390);
            this.BTizqu.Name = "BTizqu";
            this.BTizqu.Size = new System.Drawing.Size(75, 23);
            this.BTizqu.TabIndex = 0;
            this.BTizqu.Text = "<";
            this.BTizqu.UseVisualStyleBackColor = true;
            this.BTizqu.Click += new System.EventHandler(this.BTizqu_Click);
            // 
            // BTdere
            // 
            this.BTdere.Location = new System.Drawing.Point(251, 390);
            this.BTdere.Name = "BTdere";
            this.BTdere.Size = new System.Drawing.Size(75, 23);
            this.BTdere.TabIndex = 1;
            this.BTdere.Text = ">";
            this.BTdere.UseVisualStyleBackColor = true;
            this.BTdere.Click += new System.EventHandler(this.BTdere_Click);
            // 
            // TBtitol
            // 
            this.TBtitol.Location = new System.Drawing.Point(226, 48);
            this.TBtitol.Name = "TBtitol";
            this.TBtitol.Size = new System.Drawing.Size(100, 20);
            this.TBtitol.TabIndex = 2;
            // 
            // TBnumpag
            // 
            this.TBnumpag.Location = new System.Drawing.Point(226, 85);
            this.TBnumpag.Name = "TBnumpag";
            this.TBnumpag.Size = new System.Drawing.Size(100, 20);
            this.TBnumpag.TabIndex = 3;
            // 
            // TBautor
            // 
            this.TBautor.Location = new System.Drawing.Point(226, 130);
            this.TBautor.Name = "TBautor";
            this.TBautor.Size = new System.Drawing.Size(100, 20);
            this.TBautor.TabIndex = 4;
            // 
            // TBcolorPort
            // 
            this.TBcolorPort.Location = new System.Drawing.Point(226, 179);
            this.TBcolorPort.Name = "TBcolorPort";
            this.TBcolorPort.Size = new System.Drawing.Size(100, 20);
            this.TBcolorPort.TabIndex = 5;
            // 
            // TBdim
            // 
            this.TBdim.Location = new System.Drawing.Point(226, 229);
            this.TBdim.Name = "TBdim";
            this.TBdim.Size = new System.Drawing.Size(100, 20);
            this.TBdim.TabIndex = 6;
            // 
            // TBcont
            // 
            this.TBcont.Location = new System.Drawing.Point(226, 283);
            this.TBcont.Name = "TBcont";
            this.TBcont.Size = new System.Drawing.Size(100, 20);
            this.TBcont.TabIndex = 7;
            // 
            // LBtitulo
            // 
            this.LBtitulo.AutoSize = true;
            this.LBtitulo.Location = new System.Drawing.Point(27, 48);
            this.LBtitulo.Name = "LBtitulo";
            this.LBtitulo.Size = new System.Drawing.Size(33, 13);
            this.LBtitulo.TabIndex = 8;
            this.LBtitulo.Text = "Titulo";
            // 
            // LBnumpag
            // 
            this.LBnumpag.AutoSize = true;
            this.LBnumpag.Location = new System.Drawing.Point(27, 92);
            this.LBnumpag.Name = "LBnumpag";
            this.LBnumpag.Size = new System.Drawing.Size(74, 13);
            this.LBnumpag.TabIndex = 9;
            this.LBnumpag.Text = "Nº de páginas";
            // 
            // LBautor
            // 
            this.LBautor.AutoSize = true;
            this.LBautor.Location = new System.Drawing.Point(27, 137);
            this.LBautor.Name = "LBautor";
            this.LBautor.Size = new System.Drawing.Size(32, 13);
            this.LBautor.TabIndex = 10;
            this.LBautor.Text = "Autor";
            // 
            // LBcolorport
            // 
            this.LBcolorport.AutoSize = true;
            this.LBcolorport.Location = new System.Drawing.Point(27, 186);
            this.LBcolorport.Name = "LBcolorport";
            this.LBcolorport.Size = new System.Drawing.Size(70, 13);
            this.LBcolorport.TabIndex = 11;
            this.LBcolorport.Text = "Color portada";
            // 
            // LBdim
            // 
            this.LBdim.AutoSize = true;
            this.LBdim.Location = new System.Drawing.Point(27, 236);
            this.LBdim.Name = "LBdim";
            this.LBdim.Size = new System.Drawing.Size(67, 13);
            this.LBdim.TabIndex = 12;
            this.LBdim.Text = "Dimensiones";
            // 
            // LBcont
            // 
            this.LBcont.AutoSize = true;
            this.LBcont.Location = new System.Drawing.Point(26, 290);
            this.LBcont.Name = "LBcont";
            this.LBcont.Size = new System.Drawing.Size(55, 13);
            this.LBcont.TabIndex = 13;
            this.LBcont.Text = "Contenido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 444);
            this.Controls.Add(this.LBcont);
            this.Controls.Add(this.LBdim);
            this.Controls.Add(this.LBcolorport);
            this.Controls.Add(this.LBautor);
            this.Controls.Add(this.LBnumpag);
            this.Controls.Add(this.LBtitulo);
            this.Controls.Add(this.TBcont);
            this.Controls.Add(this.TBdim);
            this.Controls.Add(this.TBcolorPort);
            this.Controls.Add(this.TBautor);
            this.Controls.Add(this.TBnumpag);
            this.Controls.Add(this.TBtitol);
            this.Controls.Add(this.BTdere);
            this.Controls.Add(this.BTizqu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTizqu;
        private System.Windows.Forms.Button BTdere;
        private System.Windows.Forms.TextBox TBtitol;
        private System.Windows.Forms.TextBox TBnumpag;
        private System.Windows.Forms.TextBox TBautor;
        private System.Windows.Forms.TextBox TBcolorPort;
        private System.Windows.Forms.TextBox TBdim;
        private System.Windows.Forms.TextBox TBcont;
        private System.Windows.Forms.Label LBtitulo;
        private System.Windows.Forms.Label LBnumpag;
        private System.Windows.Forms.Label LBautor;
        private System.Windows.Forms.Label LBcolorport;
        private System.Windows.Forms.Label LBdim;
        private System.Windows.Forms.Label LBcont;
    }
}

