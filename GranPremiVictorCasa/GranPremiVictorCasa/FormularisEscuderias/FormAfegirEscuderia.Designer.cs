namespace GranPremiVictorCasa
{
    partial class FormAfegirEscuderia
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
            this.BTAfegir = new System.Windows.Forms.Button();
            this.BTTorna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBNomEsc = new System.Windows.Forms.TextBox();
            this.TBAnyFun = new System.Windows.Forms.TextBox();
            this.TBPais = new System.Windows.Forms.TextBox();
            this.TBMotor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTAfegir
            // 
            this.BTAfegir.Location = new System.Drawing.Point(28, 207);
            this.BTAfegir.Name = "BTAfegir";
            this.BTAfegir.Size = new System.Drawing.Size(75, 23);
            this.BTAfegir.TabIndex = 0;
            this.BTAfegir.Text = "Afegir";
            this.BTAfegir.UseVisualStyleBackColor = true;
            this.BTAfegir.Click += new System.EventHandler(this.BTAfegir_Click);
            // 
            // BTTorna
            // 
            this.BTTorna.Location = new System.Drawing.Point(213, 207);
            this.BTTorna.Name = "BTTorna";
            this.BTTorna.Size = new System.Drawing.Size(75, 23);
            this.BTTorna.TabIndex = 1;
            this.BTTorna.Text = "Torna";
            this.BTTorna.UseVisualStyleBackColor = true;
            this.BTTorna.Click += new System.EventHandler(this.BTTorna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom Escuderia :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Any Fundació :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pais Escuderia :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Motor :";
            // 
            // TBNomEsc
            // 
            this.TBNomEsc.Location = new System.Drawing.Point(31, 40);
            this.TBNomEsc.Name = "TBNomEsc";
            this.TBNomEsc.Size = new System.Drawing.Size(100, 20);
            this.TBNomEsc.TabIndex = 6;
            // 
            // TBAnyFun
            // 
            this.TBAnyFun.Location = new System.Drawing.Point(188, 40);
            this.TBAnyFun.Name = "TBAnyFun";
            this.TBAnyFun.Size = new System.Drawing.Size(100, 20);
            this.TBAnyFun.TabIndex = 7;
            // 
            // TBPais
            // 
            this.TBPais.Location = new System.Drawing.Point(31, 122);
            this.TBPais.Name = "TBPais";
            this.TBPais.Size = new System.Drawing.Size(100, 20);
            this.TBPais.TabIndex = 8;
            // 
            // TBMotor
            // 
            this.TBMotor.Location = new System.Drawing.Point(188, 122);
            this.TBMotor.Name = "TBMotor";
            this.TBMotor.Size = new System.Drawing.Size(100, 20);
            this.TBMotor.TabIndex = 9;
            // 
            // FormAfegirEscuderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.TBMotor);
            this.Controls.Add(this.TBPais);
            this.Controls.Add(this.TBAnyFun);
            this.Controls.Add(this.TBNomEsc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTTorna);
            this.Controls.Add(this.BTAfegir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAfegirEscuderia";
            this.Text = "FormAfegirEscuderia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTAfegir;
        private System.Windows.Forms.Button BTTorna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBNomEsc;
        private System.Windows.Forms.TextBox TBAnyFun;
        private System.Windows.Forms.TextBox TBPais;
        private System.Windows.Forms.TextBox TBMotor;
    }
}