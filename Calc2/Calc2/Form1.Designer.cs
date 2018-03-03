namespace Calc2
{
    partial class FCalc
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
            this.GBMostrar = new System.Windows.Forms.GroupBox();
            this.TBMostrar = new System.Windows.Forms.TextBox();
            this.GBBotones = new System.Windows.Forms.GroupBox();
            this.BTPotencia = new System.Windows.Forms.Button();
            this.BTsqr = new System.Windows.Forms.Button();
            this.BToff = new System.Windows.Forms.Button();
            this.BTDivide = new System.Windows.Forms.Button();
            this.BTMultiplica = new System.Windows.Forms.Button();
            this.BTResta = new System.Windows.Forms.Button();
            this.BTSuma = new System.Windows.Forms.Button();
            this.BTC = new System.Windows.Forms.Button();
            this.BT0 = new System.Windows.Forms.Button();
            this.BTPunto = new System.Windows.Forms.Button();
            this.BT9 = new System.Windows.Forms.Button();
            this.BT8 = new System.Windows.Forms.Button();
            this.BT7 = new System.Windows.Forms.Button();
            this.BT6 = new System.Windows.Forms.Button();
            this.BT5 = new System.Windows.Forms.Button();
            this.BT4 = new System.Windows.Forms.Button();
            this.BTIgual = new System.Windows.Forms.Button();
            this.BT3 = new System.Windows.Forms.Button();
            this.BT2 = new System.Windows.Forms.Button();
            this.BT1 = new System.Windows.Forms.Button();
            this.GBMostrar.SuspendLayout();
            this.GBBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBMostrar
            // 
            this.GBMostrar.Controls.Add(this.TBMostrar);
            this.GBMostrar.Location = new System.Drawing.Point(13, 13);
            this.GBMostrar.Name = "GBMostrar";
            this.GBMostrar.Size = new System.Drawing.Size(331, 59);
            this.GBMostrar.TabIndex = 0;
            this.GBMostrar.TabStop = false;
            this.GBMostrar.Text = "groupBox1";
            // 
            // TBMostrar
            // 
            this.TBMostrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TBMostrar.Location = new System.Drawing.Point(6, 20);
            this.TBMostrar.Name = "TBMostrar";
            this.TBMostrar.Size = new System.Drawing.Size(319, 30);
            this.TBMostrar.TabIndex = 0;
            this.TBMostrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBMostrar.TextChanged += new System.EventHandler(this.TBMostrar_TextChanged);
            // 
            // GBBotones
            // 
            this.GBBotones.Controls.Add(this.BTPotencia);
            this.GBBotones.Controls.Add(this.BTsqr);
            this.GBBotones.Controls.Add(this.BToff);
            this.GBBotones.Controls.Add(this.BTDivide);
            this.GBBotones.Controls.Add(this.BTMultiplica);
            this.GBBotones.Controls.Add(this.BTResta);
            this.GBBotones.Controls.Add(this.BTSuma);
            this.GBBotones.Controls.Add(this.BTC);
            this.GBBotones.Controls.Add(this.BT0);
            this.GBBotones.Controls.Add(this.BTPunto);
            this.GBBotones.Controls.Add(this.BT9);
            this.GBBotones.Controls.Add(this.BT8);
            this.GBBotones.Controls.Add(this.BT7);
            this.GBBotones.Controls.Add(this.BT6);
            this.GBBotones.Controls.Add(this.BT5);
            this.GBBotones.Controls.Add(this.BT4);
            this.GBBotones.Controls.Add(this.BTIgual);
            this.GBBotones.Controls.Add(this.BT3);
            this.GBBotones.Controls.Add(this.BT2);
            this.GBBotones.Controls.Add(this.BT1);
            this.GBBotones.Location = new System.Drawing.Point(12, 98);
            this.GBBotones.Name = "GBBotones";
            this.GBBotones.Size = new System.Drawing.Size(332, 327);
            this.GBBotones.TabIndex = 1;
            this.GBBotones.TabStop = false;
            this.GBBotones.Text = "groupBox2";
            // 
            // BTPotencia
            // 
            this.BTPotencia.Location = new System.Drawing.Point(6, 45);
            this.BTPotencia.Name = "BTPotencia";
            this.BTPotencia.Size = new System.Drawing.Size(73, 31);
            this.BTPotencia.TabIndex = 19;
            this.BTPotencia.Text = "x^2";
            this.BTPotencia.UseVisualStyleBackColor = true;
            this.BTPotencia.Click += new System.EventHandler(this.BTPotencia_Click);
            // 
            // BTsqr
            // 
            this.BTsqr.Location = new System.Drawing.Point(86, 45);
            this.BTsqr.Name = "BTsqr";
            this.BTsqr.Size = new System.Drawing.Size(76, 31);
            this.BTsqr.TabIndex = 18;
            this.BTsqr.Text = "SQR";
            this.BTsqr.UseVisualStyleBackColor = true;
            this.BTsqr.Click += new System.EventHandler(this.BTsqr_Click);
            // 
            // BToff
            // 
            this.BToff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BToff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BToff.ForeColor = System.Drawing.Color.Red;
            this.BToff.Location = new System.Drawing.Point(168, 45);
            this.BToff.Name = "BToff";
            this.BToff.Size = new System.Drawing.Size(79, 31);
            this.BToff.TabIndex = 17;
            this.BToff.Text = "OFF";
            this.BToff.UseVisualStyleBackColor = false;
            this.BToff.Click += new System.EventHandler(this.BToff_Click);
            // 
            // BTDivide
            // 
            this.BTDivide.Location = new System.Drawing.Point(253, 45);
            this.BTDivide.Name = "BTDivide";
            this.BTDivide.Size = new System.Drawing.Size(73, 29);
            this.BTDivide.TabIndex = 16;
            this.BTDivide.Text = "/";
            this.BTDivide.UseVisualStyleBackColor = true;
            this.BTDivide.Click += new System.EventHandler(this.BTDivide_Click);
            // 
            // BTMultiplica
            // 
            this.BTMultiplica.Location = new System.Drawing.Point(253, 95);
            this.BTMultiplica.Name = "BTMultiplica";
            this.BTMultiplica.Size = new System.Drawing.Size(73, 31);
            this.BTMultiplica.TabIndex = 15;
            this.BTMultiplica.Text = "*";
            this.BTMultiplica.UseVisualStyleBackColor = true;
            this.BTMultiplica.Click += new System.EventHandler(this.BTMultiplica_Click);
            // 
            // BTResta
            // 
            this.BTResta.Location = new System.Drawing.Point(253, 148);
            this.BTResta.Name = "BTResta";
            this.BTResta.Size = new System.Drawing.Size(73, 31);
            this.BTResta.TabIndex = 14;
            this.BTResta.Text = "-";
            this.BTResta.UseVisualStyleBackColor = true;
            this.BTResta.Click += new System.EventHandler(this.BTResta_Click);
            // 
            // BTSuma
            // 
            this.BTSuma.Location = new System.Drawing.Point(253, 194);
            this.BTSuma.Name = "BTSuma";
            this.BTSuma.Size = new System.Drawing.Size(73, 81);
            this.BTSuma.TabIndex = 13;
            this.BTSuma.Text = "+";
            this.BTSuma.UseVisualStyleBackColor = true;
            this.BTSuma.Click += new System.EventHandler(this.BTSuma_Click);
            // 
            // BTC
            // 
            this.BTC.Location = new System.Drawing.Point(168, 244);
            this.BTC.Name = "BTC";
            this.BTC.Size = new System.Drawing.Size(79, 31);
            this.BTC.TabIndex = 12;
            this.BTC.Text = "C";
            this.BTC.UseVisualStyleBackColor = true;
            this.BTC.Click += new System.EventHandler(this.BTC_Click);
            // 
            // BT0
            // 
            this.BT0.Location = new System.Drawing.Point(86, 244);
            this.BT0.Name = "BT0";
            this.BT0.Size = new System.Drawing.Size(76, 31);
            this.BT0.TabIndex = 11;
            this.BT0.Text = "0";
            this.BT0.UseVisualStyleBackColor = true;
            this.BT0.Click += new System.EventHandler(this.BT0_Click);
            // 
            // BTPunto
            // 
            this.BTPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPunto.Location = new System.Drawing.Point(7, 244);
            this.BTPunto.Name = "BTPunto";
            this.BTPunto.Size = new System.Drawing.Size(73, 31);
            this.BTPunto.TabIndex = 10;
            this.BTPunto.Text = ".";
            this.BTPunto.UseVisualStyleBackColor = true;
            this.BTPunto.Click += new System.EventHandler(this.BTPunto_Click);
            // 
            // BT9
            // 
            this.BT9.Location = new System.Drawing.Point(168, 95);
            this.BT9.Name = "BT9";
            this.BT9.Size = new System.Drawing.Size(79, 31);
            this.BT9.TabIndex = 9;
            this.BT9.Text = "9";
            this.BT9.UseVisualStyleBackColor = true;
            this.BT9.Click += new System.EventHandler(this.BT9_Click);
            // 
            // BT8
            // 
            this.BT8.Location = new System.Drawing.Point(86, 95);
            this.BT8.Name = "BT8";
            this.BT8.Size = new System.Drawing.Size(76, 31);
            this.BT8.TabIndex = 8;
            this.BT8.Text = "8";
            this.BT8.UseVisualStyleBackColor = true;
            this.BT8.Click += new System.EventHandler(this.BT8_Click);
            // 
            // BT7
            // 
            this.BT7.Location = new System.Drawing.Point(7, 95);
            this.BT7.Name = "BT7";
            this.BT7.Size = new System.Drawing.Size(73, 31);
            this.BT7.TabIndex = 7;
            this.BT7.Text = "7";
            this.BT7.UseVisualStyleBackColor = true;
            this.BT7.Click += new System.EventHandler(this.BT7_Click);
            // 
            // BT6
            // 
            this.BT6.Location = new System.Drawing.Point(168, 148);
            this.BT6.Name = "BT6";
            this.BT6.Size = new System.Drawing.Size(79, 31);
            this.BT6.TabIndex = 6;
            this.BT6.Text = "6";
            this.BT6.UseVisualStyleBackColor = true;
            this.BT6.Click += new System.EventHandler(this.BT6_Click);
            // 
            // BT5
            // 
            this.BT5.Location = new System.Drawing.Point(86, 148);
            this.BT5.Name = "BT5";
            this.BT5.Size = new System.Drawing.Size(76, 31);
            this.BT5.TabIndex = 5;
            this.BT5.Text = "5";
            this.BT5.UseVisualStyleBackColor = true;
            this.BT5.Click += new System.EventHandler(this.BT5_Click);
            // 
            // BT4
            // 
            this.BT4.Location = new System.Drawing.Point(7, 148);
            this.BT4.Name = "BT4";
            this.BT4.Size = new System.Drawing.Size(73, 31);
            this.BT4.TabIndex = 4;
            this.BT4.Text = "4";
            this.BT4.UseVisualStyleBackColor = true;
            this.BT4.Click += new System.EventHandler(this.BT4_Click);
            // 
            // BTIgual
            // 
            this.BTIgual.Location = new System.Drawing.Point(7, 290);
            this.BTIgual.Name = "BTIgual";
            this.BTIgual.Size = new System.Drawing.Size(319, 31);
            this.BTIgual.TabIndex = 3;
            this.BTIgual.Text = "=";
            this.BTIgual.UseVisualStyleBackColor = true;
            this.BTIgual.Click += new System.EventHandler(this.BTIgual_Click);
            // 
            // BT3
            // 
            this.BT3.Location = new System.Drawing.Point(168, 194);
            this.BT3.Name = "BT3";
            this.BT3.Size = new System.Drawing.Size(79, 31);
            this.BT3.TabIndex = 2;
            this.BT3.Text = "3";
            this.BT3.UseVisualStyleBackColor = true;
            this.BT3.Click += new System.EventHandler(this.BT3_Click);
            // 
            // BT2
            // 
            this.BT2.Location = new System.Drawing.Point(86, 194);
            this.BT2.Name = "BT2";
            this.BT2.Size = new System.Drawing.Size(76, 31);
            this.BT2.TabIndex = 1;
            this.BT2.Text = "2";
            this.BT2.UseVisualStyleBackColor = true;
            this.BT2.Click += new System.EventHandler(this.BT2_Click);
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(7, 194);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(73, 31);
            this.BT1.TabIndex = 0;
            this.BT1.Text = "1";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // FCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 437);
            this.Controls.Add(this.GBBotones);
            this.Controls.Add(this.GBMostrar);
            this.Name = "FCalc";
            this.Text = "Calculadora";
            this.GBMostrar.ResumeLayout(false);
            this.GBMostrar.PerformLayout();
            this.GBBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBMostrar;
        private System.Windows.Forms.TextBox TBMostrar;
        private System.Windows.Forms.GroupBox GBBotones;
        private System.Windows.Forms.Button BTPotencia;
        private System.Windows.Forms.Button BTsqr;
        private System.Windows.Forms.Button BToff;
        private System.Windows.Forms.Button BTDivide;
        private System.Windows.Forms.Button BTMultiplica;
        private System.Windows.Forms.Button BTResta;
        private System.Windows.Forms.Button BTSuma;
        private System.Windows.Forms.Button BTC;
        private System.Windows.Forms.Button BT0;
        private System.Windows.Forms.Button BTPunto;
        private System.Windows.Forms.Button BT9;
        private System.Windows.Forms.Button BT8;
        private System.Windows.Forms.Button BT7;
        private System.Windows.Forms.Button BT6;
        private System.Windows.Forms.Button BT5;
        private System.Windows.Forms.Button BT4;
        private System.Windows.Forms.Button BTIgual;
        private System.Windows.Forms.Button BT3;
        private System.Windows.Forms.Button BT2;
        private System.Windows.Forms.Button BT1;
    }
}

