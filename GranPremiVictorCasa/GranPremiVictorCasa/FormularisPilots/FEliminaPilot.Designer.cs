namespace GranPremiVictorCasa.FormularisPilots
{
    partial class FEliminaPilot
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
            this.TBNompilot = new System.Windows.Forms.TextBox();
            this.BTBuscaPilot = new System.Windows.Forms.Button();
            this.LBNomPilot = new System.Windows.Forms.Label();
            this.LBNacionalitatPilot = new System.Windows.Forms.Label();
            this.LBDorsalPilot = new System.Windows.Forms.Label();
            this.LBEscuderiaPilot = new System.Windows.Forms.Label();
            this.BTEliminaPilot = new System.Windows.Forms.Button();
            this.BTTornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom pilot:";
            // 
            // TBNompilot
            // 
            this.TBNompilot.Location = new System.Drawing.Point(96, 10);
            this.TBNompilot.Name = "TBNompilot";
            this.TBNompilot.Size = new System.Drawing.Size(176, 20);
            this.TBNompilot.TabIndex = 1;
            // 
            // BTBuscaPilot
            // 
            this.BTBuscaPilot.Location = new System.Drawing.Point(197, 49);
            this.BTBuscaPilot.Name = "BTBuscaPilot";
            this.BTBuscaPilot.Size = new System.Drawing.Size(75, 23);
            this.BTBuscaPilot.TabIndex = 2;
            this.BTBuscaPilot.Text = "Buscar";
            this.BTBuscaPilot.UseVisualStyleBackColor = true;
            this.BTBuscaPilot.Click += new System.EventHandler(this.BTBuscaPilot_Click);
            // 
            // LBNomPilot
            // 
            this.LBNomPilot.AutoSize = true;
            this.LBNomPilot.Location = new System.Drawing.Point(16, 97);
            this.LBNomPilot.Name = "LBNomPilot";
            this.LBNomPilot.Size = new System.Drawing.Size(10, 13);
            this.LBNomPilot.TabIndex = 3;
            this.LBNomPilot.Text = ":";
            // 
            // LBNacionalitatPilot
            // 
            this.LBNacionalitatPilot.AutoSize = true;
            this.LBNacionalitatPilot.Location = new System.Drawing.Point(142, 97);
            this.LBNacionalitatPilot.Name = "LBNacionalitatPilot";
            this.LBNacionalitatPilot.Size = new System.Drawing.Size(10, 13);
            this.LBNacionalitatPilot.TabIndex = 4;
            this.LBNacionalitatPilot.Text = ":";
            // 
            // LBDorsalPilot
            // 
            this.LBDorsalPilot.AutoSize = true;
            this.LBDorsalPilot.Location = new System.Drawing.Point(16, 169);
            this.LBDorsalPilot.Name = "LBDorsalPilot";
            this.LBDorsalPilot.Size = new System.Drawing.Size(10, 13);
            this.LBDorsalPilot.TabIndex = 5;
            this.LBDorsalPilot.Text = ":";
            // 
            // LBEscuderiaPilot
            // 
            this.LBEscuderiaPilot.AutoSize = true;
            this.LBEscuderiaPilot.Location = new System.Drawing.Point(142, 169);
            this.LBEscuderiaPilot.Name = "LBEscuderiaPilot";
            this.LBEscuderiaPilot.Size = new System.Drawing.Size(10, 13);
            this.LBEscuderiaPilot.TabIndex = 6;
            this.LBEscuderiaPilot.Text = ":";
            // 
            // BTEliminaPilot
            // 
            this.BTEliminaPilot.Location = new System.Drawing.Point(16, 216);
            this.BTEliminaPilot.Name = "BTEliminaPilot";
            this.BTEliminaPilot.Size = new System.Drawing.Size(75, 23);
            this.BTEliminaPilot.TabIndex = 7;
            this.BTEliminaPilot.Text = "Elimina";
            this.BTEliminaPilot.UseVisualStyleBackColor = true;
            this.BTEliminaPilot.Click += new System.EventHandler(this.BTEliminaPilot_Click);
            // 
            // BTTornar
            // 
            this.BTTornar.Location = new System.Drawing.Point(197, 216);
            this.BTTornar.Name = "BTTornar";
            this.BTTornar.Size = new System.Drawing.Size(75, 23);
            this.BTTornar.TabIndex = 8;
            this.BTTornar.Text = "Tornar";
            this.BTTornar.UseVisualStyleBackColor = true;
            this.BTTornar.Click += new System.EventHandler(this.BTTornar_Click);
            // 
            // FEliminaPilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 261);
            this.Controls.Add(this.BTTornar);
            this.Controls.Add(this.BTEliminaPilot);
            this.Controls.Add(this.LBEscuderiaPilot);
            this.Controls.Add(this.LBDorsalPilot);
            this.Controls.Add(this.LBNacionalitatPilot);
            this.Controls.Add(this.LBNomPilot);
            this.Controls.Add(this.BTBuscaPilot);
            this.Controls.Add(this.TBNompilot);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FEliminaPilot";
            this.Text = "FEliminaPilot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNompilot;
        private System.Windows.Forms.Button BTBuscaPilot;
        private System.Windows.Forms.Label LBNomPilot;
        private System.Windows.Forms.Label LBNacionalitatPilot;
        private System.Windows.Forms.Label LBDorsalPilot;
        private System.Windows.Forms.Label LBEscuderiaPilot;
        private System.Windows.Forms.Button BTEliminaPilot;
        private System.Windows.Forms.Button BTTornar;
    }
}