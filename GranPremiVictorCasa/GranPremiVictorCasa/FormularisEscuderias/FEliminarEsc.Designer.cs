namespace GranPremiVictorCasa.FormularisEscuderias
{
    partial class FEliminarEsc
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
            this.TBNomEscEliminaEsc = new System.Windows.Forms.TextBox();
            this.LBNomEscElimEsc = new System.Windows.Forms.Label();
            this.LBPaisFElim = new System.Windows.Forms.Label();
            this.LBMotorFElimi = new System.Windows.Forms.Label();
            this.LBAnyFElimina = new System.Windows.Forms.Label();
            this.BTBuscarEsc = new System.Windows.Forms.Button();
            this.BTEliminarEsc = new System.Windows.Forms.Button();
            this.BTTornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Escuderia : ";
            // 
            // TBNomEscEliminaEsc
            // 
            this.TBNomEscEliminaEsc.Location = new System.Drawing.Point(159, 13);
            this.TBNomEscEliminaEsc.Name = "TBNomEscEliminaEsc";
            this.TBNomEscEliminaEsc.Size = new System.Drawing.Size(142, 20);
            this.TBNomEscEliminaEsc.TabIndex = 1;
            // 
            // LBNomEscElimEsc
            // 
            this.LBNomEscElimEsc.AutoSize = true;
            this.LBNomEscElimEsc.Location = new System.Drawing.Point(16, 73);
            this.LBNomEscElimEsc.Name = "LBNomEscElimEsc";
            this.LBNomEscElimEsc.Size = new System.Drawing.Size(10, 13);
            this.LBNomEscElimEsc.TabIndex = 2;
            this.LBNomEscElimEsc.Text = ":";
            // 
            // LBPaisFElim
            // 
            this.LBPaisFElim.AutoSize = true;
            this.LBPaisFElim.Location = new System.Drawing.Point(172, 73);
            this.LBPaisFElim.Name = "LBPaisFElim";
            this.LBPaisFElim.Size = new System.Drawing.Size(10, 13);
            this.LBPaisFElim.TabIndex = 3;
            this.LBPaisFElim.Text = ":";
            // 
            // LBMotorFElimi
            // 
            this.LBMotorFElimi.AutoSize = true;
            this.LBMotorFElimi.Location = new System.Drawing.Point(16, 156);
            this.LBMotorFElimi.Name = "LBMotorFElimi";
            this.LBMotorFElimi.Size = new System.Drawing.Size(10, 13);
            this.LBMotorFElimi.TabIndex = 4;
            this.LBMotorFElimi.Text = ":";
            // 
            // LBAnyFElimina
            // 
            this.LBAnyFElimina.AutoSize = true;
            this.LBAnyFElimina.Location = new System.Drawing.Point(172, 156);
            this.LBAnyFElimina.Name = "LBAnyFElimina";
            this.LBAnyFElimina.Size = new System.Drawing.Size(10, 13);
            this.LBAnyFElimina.TabIndex = 5;
            this.LBAnyFElimina.Text = ":";
            this.LBAnyFElimina.Click += new System.EventHandler(this.LBAnyFElimina_Click);
            // 
            // BTBuscarEsc
            // 
            this.BTBuscarEsc.Location = new System.Drawing.Point(227, 40);
            this.BTBuscarEsc.Name = "BTBuscarEsc";
            this.BTBuscarEsc.Size = new System.Drawing.Size(75, 23);
            this.BTBuscarEsc.TabIndex = 6;
            this.BTBuscarEsc.Text = "Buscar";
            this.BTBuscarEsc.UseVisualStyleBackColor = true;
            this.BTBuscarEsc.Click += new System.EventHandler(this.BTBuscarEsc_Click);
            // 
            // BTEliminarEsc
            // 
            this.BTEliminarEsc.Location = new System.Drawing.Point(16, 217);
            this.BTEliminarEsc.Name = "BTEliminarEsc";
            this.BTEliminarEsc.Size = new System.Drawing.Size(75, 23);
            this.BTEliminarEsc.TabIndex = 7;
            this.BTEliminarEsc.Text = "Eliminar";
            this.BTEliminarEsc.UseVisualStyleBackColor = true;
            this.BTEliminarEsc.Click += new System.EventHandler(this.BTEliminarEsc_Click);
            // 
            // BTTornar
            // 
            this.BTTornar.Location = new System.Drawing.Point(226, 217);
            this.BTTornar.Name = "BTTornar";
            this.BTTornar.Size = new System.Drawing.Size(75, 23);
            this.BTTornar.TabIndex = 8;
            this.BTTornar.Text = "Tornar";
            this.BTTornar.UseVisualStyleBackColor = true;
            this.BTTornar.Click += new System.EventHandler(this.BTTornar_Click);
            // 
            // FEliminarEsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.BTTornar);
            this.Controls.Add(this.BTEliminarEsc);
            this.Controls.Add(this.BTBuscarEsc);
            this.Controls.Add(this.LBAnyFElimina);
            this.Controls.Add(this.LBMotorFElimi);
            this.Controls.Add(this.LBPaisFElim);
            this.Controls.Add(this.LBNomEscElimEsc);
            this.Controls.Add(this.TBNomEscEliminaEsc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FEliminarEsc";
            this.Text = "FEliminarEsc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNomEscEliminaEsc;
        private System.Windows.Forms.Label LBNomEscElimEsc;
        private System.Windows.Forms.Label LBPaisFElim;
        private System.Windows.Forms.Label LBMotorFElimi;
        private System.Windows.Forms.Label LBAnyFElimina;
        private System.Windows.Forms.Button BTBuscarEsc;
        private System.Windows.Forms.Button BTEliminarEsc;
        private System.Windows.Forms.Button BTTornar;
    }
}