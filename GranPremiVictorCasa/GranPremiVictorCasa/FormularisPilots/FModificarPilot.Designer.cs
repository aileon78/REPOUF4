namespace GranPremiVictorCasa.FormularisPilots
{
    partial class FModificarPilot
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
            this.label4 = new System.Windows.Forms.Label();
            this.TBModNomPilot = new System.Windows.Forms.TextBox();
            this.TBModNacionalitat = new System.Windows.Forms.TextBox();
            this.TBModDorsal = new System.Windows.Forms.TextBox();
            this.BTPrimer = new System.Windows.Forms.Button();
            this.BTUltim = new System.Windows.Forms.Button();
            this.BTAnterior = new System.Windows.Forms.Button();
            this.BTSeguent = new System.Windows.Forms.Button();
            this.BTModifica = new System.Windows.Forms.Button();
            this.BTTorna = new System.Windows.Forms.Button();
            this.TBNomPilot = new System.Windows.Forms.TextBox();
            this.TBNacionalitat = new System.Windows.Forms.TextBox();
            this.TBDorsal = new System.Windows.Forms.TextBox();
            this.CBEscuderia = new System.Windows.Forms.ComboBox();
            this.CBModEscuderiaPilot = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nacionalitat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "dorsal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "escuderia:";
            // 
            // TBModNomPilot
            // 
            this.TBModNomPilot.Location = new System.Drawing.Point(12, 29);
            this.TBModNomPilot.Name = "TBModNomPilot";
            this.TBModNomPilot.Size = new System.Drawing.Size(100, 20);
            this.TBModNomPilot.TabIndex = 4;
            // 
            // TBModNacionalitat
            // 
            this.TBModNacionalitat.Location = new System.Drawing.Point(161, 30);
            this.TBModNacionalitat.Name = "TBModNacionalitat";
            this.TBModNacionalitat.Size = new System.Drawing.Size(100, 20);
            this.TBModNacionalitat.TabIndex = 5;
            // 
            // TBModDorsal
            // 
            this.TBModDorsal.Location = new System.Drawing.Point(12, 100);
            this.TBModDorsal.Name = "TBModDorsal";
            this.TBModDorsal.Size = new System.Drawing.Size(100, 20);
            this.TBModDorsal.TabIndex = 6;
            // 
            // BTPrimer
            // 
            this.BTPrimer.Location = new System.Drawing.Point(12, 151);
            this.BTPrimer.Name = "BTPrimer";
            this.BTPrimer.Size = new System.Drawing.Size(48, 23);
            this.BTPrimer.TabIndex = 8;
            this.BTPrimer.Text = "<<";
            this.BTPrimer.UseVisualStyleBackColor = true;
            this.BTPrimer.Click += new System.EventHandler(this.BTPrimer_Click);
            // 
            // BTUltim
            // 
            this.BTUltim.Location = new System.Drawing.Point(213, 151);
            this.BTUltim.Name = "BTUltim";
            this.BTUltim.Size = new System.Drawing.Size(48, 23);
            this.BTUltim.TabIndex = 9;
            this.BTUltim.Text = ">>";
            this.BTUltim.UseVisualStyleBackColor = true;
            this.BTUltim.Click += new System.EventHandler(this.BTUltim_Click);
            // 
            // BTAnterior
            // 
            this.BTAnterior.Location = new System.Drawing.Point(64, 151);
            this.BTAnterior.Name = "BTAnterior";
            this.BTAnterior.Size = new System.Drawing.Size(48, 23);
            this.BTAnterior.TabIndex = 10;
            this.BTAnterior.Text = "<";
            this.BTAnterior.UseVisualStyleBackColor = true;
            this.BTAnterior.Click += new System.EventHandler(this.BTAnterior_Click);
            // 
            // BTSeguent
            // 
            this.BTSeguent.Location = new System.Drawing.Point(159, 151);
            this.BTSeguent.Name = "BTSeguent";
            this.BTSeguent.Size = new System.Drawing.Size(48, 23);
            this.BTSeguent.TabIndex = 11;
            this.BTSeguent.Text = ">";
            this.BTSeguent.UseVisualStyleBackColor = true;
            this.BTSeguent.Click += new System.EventHandler(this.BTSeguent_Click);
            // 
            // BTModifica
            // 
            this.BTModifica.Location = new System.Drawing.Point(12, 201);
            this.BTModifica.Name = "BTModifica";
            this.BTModifica.Size = new System.Drawing.Size(75, 23);
            this.BTModifica.TabIndex = 12;
            this.BTModifica.Text = "Modifica";
            this.BTModifica.UseVisualStyleBackColor = true;
            this.BTModifica.Click += new System.EventHandler(this.BTModifica_Click);
            // 
            // BTTorna
            // 
            this.BTTorna.Location = new System.Drawing.Point(186, 201);
            this.BTTorna.Name = "BTTorna";
            this.BTTorna.Size = new System.Drawing.Size(75, 23);
            this.BTTorna.TabIndex = 13;
            this.BTTorna.Text = "Torna";
            this.BTTorna.UseVisualStyleBackColor = true;
            this.BTTorna.Click += new System.EventHandler(this.BTTorna_Click);
            // 
            // TBNomPilot
            // 
            this.TBNomPilot.Location = new System.Drawing.Point(12, 29);
            this.TBNomPilot.Name = "TBNomPilot";
            this.TBNomPilot.Size = new System.Drawing.Size(100, 20);
            this.TBNomPilot.TabIndex = 4;
            // 
            // TBNacionalitat
            // 
            this.TBNacionalitat.Location = new System.Drawing.Point(161, 30);
            this.TBNacionalitat.Name = "TBNacionalitat";
            this.TBNacionalitat.Size = new System.Drawing.Size(100, 20);
            this.TBNacionalitat.TabIndex = 5;
            // 
            // TBDorsal
            // 
            this.TBDorsal.Location = new System.Drawing.Point(12, 100);
            this.TBDorsal.Name = "TBDorsal";
            this.TBDorsal.Size = new System.Drawing.Size(100, 20);
            this.TBDorsal.TabIndex = 6;
            // 
            // CBEscuderia
            // 
            this.CBEscuderia.FormattingEnabled = true;
            this.CBEscuderia.Location = new System.Drawing.Point(161, 98);
            this.CBEscuderia.Name = "CBEscuderia";
            this.CBEscuderia.Size = new System.Drawing.Size(100, 21);
            this.CBEscuderia.TabIndex = 7;
            // 
            // CBModEscuderiaPilot
            // 
            this.CBModEscuderiaPilot.FormattingEnabled = true;
            this.CBModEscuderiaPilot.Location = new System.Drawing.Point(161, 100);
            this.CBModEscuderiaPilot.Name = "CBModEscuderiaPilot";
            this.CBModEscuderiaPilot.Size = new System.Drawing.Size(100, 21);
            this.CBModEscuderiaPilot.TabIndex = 14;
            // 
            // FModificarPilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 238);
            this.Controls.Add(this.CBModEscuderiaPilot);
            this.Controls.Add(this.BTTorna);
            this.Controls.Add(this.BTModifica);
            this.Controls.Add(this.BTSeguent);
            this.Controls.Add(this.BTAnterior);
            this.Controls.Add(this.BTUltim);
            this.Controls.Add(this.BTPrimer);
            this.Controls.Add(this.TBModDorsal);
            this.Controls.Add(this.TBModNacionalitat);
            this.Controls.Add(this.TBModNomPilot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FModificarPilot";
            this.Text = "FModificarPilot";
            this.Load += new System.EventHandler(this.FModificarPilot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBNomPilot;
        private System.Windows.Forms.TextBox TBNacionalitat;
        private System.Windows.Forms.TextBox TBDorsal;
        private System.Windows.Forms.ComboBox CBEscuderia;
        private System.Windows.Forms.Button BTPrimer;
        private System.Windows.Forms.Button BTUltim;
        private System.Windows.Forms.Button BTAnterior;
        private System.Windows.Forms.Button BTSeguent;
        private System.Windows.Forms.Button BTModifica;
        private System.Windows.Forms.Button BTTorna;
        private System.Windows.Forms.TextBox TBModNomPilot;
        private System.Windows.Forms.TextBox TBModNacionalitat;
        private System.Windows.Forms.TextBox TBModDorsal;
        private System.Windows.Forms.ComboBox CBModEscuderiaPilot;
    }
}