namespace GranPremiVictorCasa.FormularisEscuderias
{
    partial class FModificarEsc
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
            this.TBModNomEsc = new System.Windows.Forms.TextBox();
            this.TBModAnyEsc = new System.Windows.Forms.TextBox();
            this.TBModPaisEsc = new System.Windows.Forms.TextBox();
            this.TBModMotorEsc = new System.Windows.Forms.TextBox();
            this.BTPrimer = new System.Windows.Forms.Button();
            this.BTAnterior = new System.Windows.Forms.Button();
            this.BTSiguiente = new System.Windows.Forms.Button();
            this.BTUltimo = new System.Windows.Forms.Button();
            this.BTModificar = new System.Windows.Forms.Button();
            this.BTTornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Escuderia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año Fundacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "País Escuderia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motor:";
            // 
            // TBModNomEsc
            // 
            this.TBModNomEsc.Location = new System.Drawing.Point(29, 43);
            this.TBModNomEsc.Name = "TBModNomEsc";
            this.TBModNomEsc.Size = new System.Drawing.Size(100, 20);
            this.TBModNomEsc.TabIndex = 4;
            // 
            // TBModAnyEsc
            // 
            this.TBModAnyEsc.Location = new System.Drawing.Point(228, 43);
            this.TBModAnyEsc.Name = "TBModAnyEsc";
            this.TBModAnyEsc.Size = new System.Drawing.Size(100, 20);
            this.TBModAnyEsc.TabIndex = 5;
            // 
            // TBModPaisEsc
            // 
            this.TBModPaisEsc.Location = new System.Drawing.Point(29, 129);
            this.TBModPaisEsc.Name = "TBModPaisEsc";
            this.TBModPaisEsc.Size = new System.Drawing.Size(100, 20);
            this.TBModPaisEsc.TabIndex = 6;
            // 
            // TBModMotorEsc
            // 
            this.TBModMotorEsc.Location = new System.Drawing.Point(228, 129);
            this.TBModMotorEsc.Name = "TBModMotorEsc";
            this.TBModMotorEsc.Size = new System.Drawing.Size(100, 20);
            this.TBModMotorEsc.TabIndex = 7;
            // 
            // BTPrimer
            // 
            this.BTPrimer.Location = new System.Drawing.Point(29, 174);
            this.BTPrimer.Name = "BTPrimer";
            this.BTPrimer.Size = new System.Drawing.Size(51, 23);
            this.BTPrimer.TabIndex = 8;
            this.BTPrimer.Text = "<<";
            this.BTPrimer.UseVisualStyleBackColor = true;
            this.BTPrimer.Click += new System.EventHandler(this.BTPrimer_Click);
            // 
            // BTAnterior
            // 
            this.BTAnterior.Location = new System.Drawing.Point(95, 174);
            this.BTAnterior.Name = "BTAnterior";
            this.BTAnterior.Size = new System.Drawing.Size(51, 23);
            this.BTAnterior.TabIndex = 9;
            this.BTAnterior.Text = "<";
            this.BTAnterior.UseVisualStyleBackColor = true;
            this.BTAnterior.Click += new System.EventHandler(this.BTAnterior_Click);
            // 
            // BTSiguiente
            // 
            this.BTSiguiente.Location = new System.Drawing.Point(211, 174);
            this.BTSiguiente.Name = "BTSiguiente";
            this.BTSiguiente.Size = new System.Drawing.Size(51, 23);
            this.BTSiguiente.TabIndex = 10;
            this.BTSiguiente.Text = ">";
            this.BTSiguiente.UseVisualStyleBackColor = true;
            this.BTSiguiente.Click += new System.EventHandler(this.BTSiguiente_Click);
            // 
            // BTUltimo
            // 
            this.BTUltimo.Location = new System.Drawing.Point(277, 174);
            this.BTUltimo.Name = "BTUltimo";
            this.BTUltimo.Size = new System.Drawing.Size(51, 23);
            this.BTUltimo.TabIndex = 11;
            this.BTUltimo.Text = ">>";
            this.BTUltimo.UseVisualStyleBackColor = true;
            this.BTUltimo.Click += new System.EventHandler(this.BTUltimo_Click);
            // 
            // BTModificar
            // 
            this.BTModificar.Location = new System.Drawing.Point(29, 224);
            this.BTModificar.Name = "BTModificar";
            this.BTModificar.Size = new System.Drawing.Size(75, 23);
            this.BTModificar.TabIndex = 12;
            this.BTModificar.Text = "Modificar";
            this.BTModificar.UseVisualStyleBackColor = true;
            this.BTModificar.Click += new System.EventHandler(this.BTModificar_Click);
            // 
            // BTTornar
            // 
            this.BTTornar.Location = new System.Drawing.Point(256, 226);
            this.BTTornar.Name = "BTTornar";
            this.BTTornar.Size = new System.Drawing.Size(72, 23);
            this.BTTornar.TabIndex = 13;
            this.BTTornar.Text = "Tornar";
            this.BTTornar.UseVisualStyleBackColor = true;
            this.BTTornar.Click += new System.EventHandler(this.BTTornar_Click);
            // 
            // FModificarEsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this.BTTornar);
            this.Controls.Add(this.BTModificar);
            this.Controls.Add(this.BTUltimo);
            this.Controls.Add(this.BTSiguiente);
            this.Controls.Add(this.BTAnterior);
            this.Controls.Add(this.BTPrimer);
            this.Controls.Add(this.TBModMotorEsc);
            this.Controls.Add(this.TBModPaisEsc);
            this.Controls.Add(this.TBModAnyEsc);
            this.Controls.Add(this.TBModNomEsc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FModificarEsc";
            this.Text = "FModificarEsc";
            this.Load += new System.EventHandler(this.FModificarEsc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBModNomEsc;
        private System.Windows.Forms.TextBox TBModAnyEsc;
        private System.Windows.Forms.TextBox TBModPaisEsc;
        private System.Windows.Forms.TextBox TBModMotorEsc;
        private System.Windows.Forms.Button BTPrimer;
        private System.Windows.Forms.Button BTAnterior;
        private System.Windows.Forms.Button BTSiguiente;
        private System.Windows.Forms.Button BTUltimo;
        private System.Windows.Forms.Button BTModificar;
        private System.Windows.Forms.Button BTTornar;
    }
}