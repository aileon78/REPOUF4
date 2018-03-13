namespace GranPremiVictorCasa.FormularisPilots
{
    partial class FAfegeixPilot
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
            this.BTAfegir = new System.Windows.Forms.Button();
            this.BTTornar = new System.Windows.Forms.Button();
            this.TBNompilot = new System.Windows.Forms.TextBox();
            this.TBNacionalitat = new System.Windows.Forms.TextBox();
            this.TBDorsal = new System.Windows.Forms.TextBox();
            this.CBEscuderia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nacionalitat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "dorsal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "escuderia";
            // 
            // BTAfegir
            // 
            this.BTAfegir.Location = new System.Drawing.Point(16, 175);
            this.BTAfegir.Name = "BTAfegir";
            this.BTAfegir.Size = new System.Drawing.Size(75, 23);
            this.BTAfegir.TabIndex = 4;
            this.BTAfegir.Text = "Afegir";
            this.BTAfegir.UseVisualStyleBackColor = true;
            this.BTAfegir.Click += new System.EventHandler(this.BTAfegir_Click);
            // 
            // BTTornar
            // 
            this.BTTornar.Location = new System.Drawing.Point(182, 175);
            this.BTTornar.Name = "BTTornar";
            this.BTTornar.Size = new System.Drawing.Size(75, 23);
            this.BTTornar.TabIndex = 5;
            this.BTTornar.Text = "Torna";
            this.BTTornar.UseVisualStyleBackColor = true;
            this.BTTornar.Click += new System.EventHandler(this.BTTornar_Click);
            // 
            // TBNompilot
            // 
            this.TBNompilot.Location = new System.Drawing.Point(13, 30);
            this.TBNompilot.Name = "TBNompilot";
            this.TBNompilot.Size = new System.Drawing.Size(100, 20);
            this.TBNompilot.TabIndex = 6;
            // 
            // TBNacionalitat
            // 
            this.TBNacionalitat.Location = new System.Drawing.Point(157, 29);
            this.TBNacionalitat.Name = "TBNacionalitat";
            this.TBNacionalitat.Size = new System.Drawing.Size(100, 20);
            this.TBNacionalitat.TabIndex = 7;
            // 
            // TBDorsal
            // 
            this.TBDorsal.Location = new System.Drawing.Point(16, 108);
            this.TBDorsal.Name = "TBDorsal";
            this.TBDorsal.Size = new System.Drawing.Size(100, 20);
            this.TBDorsal.TabIndex = 8;
            // 
            // CBEscuderia
            // 
            this.CBEscuderia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CBEscuderia.FormattingEnabled = true;
            this.CBEscuderia.Location = new System.Drawing.Point(157, 107);
            this.CBEscuderia.Name = "CBEscuderia";
            this.CBEscuderia.Size = new System.Drawing.Size(100, 21);
            this.CBEscuderia.TabIndex = 9;
            // 
            // FAfegeixPilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(271, 225);
            this.Controls.Add(this.CBEscuderia);
            this.Controls.Add(this.TBDorsal);
            this.Controls.Add(this.TBNacionalitat);
            this.Controls.Add(this.TBNompilot);
            this.Controls.Add(this.BTTornar);
            this.Controls.Add(this.BTAfegir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FAfegeixPilot";
            this.Text = "FAfegeixPilot";
            this.Load += new System.EventHandler(this.FAfegeixPilot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTAfegir;
        private System.Windows.Forms.Button BTTornar;
        private System.Windows.Forms.TextBox TBNompilot;
        private System.Windows.Forms.TextBox TBNacionalitat;
        private System.Windows.Forms.TextBox TBDorsal;
        private System.Windows.Forms.ComboBox CBEscuderia;
    }
}