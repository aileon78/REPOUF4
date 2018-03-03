namespace ArraysVector
{
    partial class FRGastosdiarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTnuevo = new System.Windows.Forms.Button();
            this.BTsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTcantidaddias = new System.Windows.Forms.TextBox();
            this.TXTtotalgastos = new System.Windows.Forms.TextBox();
            this.TXTdiamayor = new System.Windows.Forms.TextBox();
            this.TXTgastomayos = new System.Windows.Forms.TextBox();
            this.CBXgastos = new System.Windows.Forms.ComboBox();
            this.BTingresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTingresar);
            this.groupBox1.Controls.Add(this.TXTcantidaddias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBXgastos);
            this.groupBox2.Controls.Add(this.TXTgastomayos);
            this.groupBox2.Controls.Add(this.TXTdiamayor);
            this.groupBox2.Controls.Add(this.TXTtotalgastos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BTnuevo);
            this.groupBox2.Controls.Add(this.BTsalir);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BTnuevo
            // 
            this.BTnuevo.Location = new System.Drawing.Point(44, 202);
            this.BTnuevo.Name = "BTnuevo";
            this.BTnuevo.Size = new System.Drawing.Size(74, 31);
            this.BTnuevo.TabIndex = 7;
            this.BTnuevo.Text = "NUEVO";
            this.BTnuevo.UseVisualStyleBackColor = true;
            this.BTnuevo.Click += new System.EventHandler(this.BTnuevo_Click);
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(235, 202);
            this.BTsalir.Name = "BTsalir";
            this.BTsalir.Size = new System.Drawing.Size(81, 31);
            this.BTsalir.TabIndex = 6;
            this.BTsalir.Text = "&SALIR";
            this.BTsalir.UseVisualStyleBackColor = true;
            this.BTsalir.Click += new System.EventHandler(this.BTsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gastos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total de gastos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mayor gasto";
            // 
            // TXTcantidaddias
            // 
            this.TXTcantidaddias.Location = new System.Drawing.Point(158, 59);
            this.TXTcantidaddias.Name = "TXTcantidaddias";
            this.TXTcantidaddias.Size = new System.Drawing.Size(152, 20);
            this.TXTcantidaddias.TabIndex = 1;
            // 
            // TXTtotalgastos
            // 
            this.TXTtotalgastos.Location = new System.Drawing.Point(101, 77);
            this.TXTtotalgastos.Name = "TXTtotalgastos";
            this.TXTtotalgastos.Size = new System.Drawing.Size(134, 20);
            this.TXTtotalgastos.TabIndex = 2;
            // 
            // TXTdiamayor
            // 
            this.TXTdiamayor.Location = new System.Drawing.Point(101, 131);
            this.TXTdiamayor.Name = "TXTdiamayor";
            this.TXTdiamayor.Size = new System.Drawing.Size(104, 20);
            this.TXTdiamayor.TabIndex = 10;
            // 
            // TXTgastomayos
            // 
            this.TXTgastomayos.Location = new System.Drawing.Point(212, 131);
            this.TXTgastomayos.Name = "TXTgastomayos";
            this.TXTgastomayos.Size = new System.Drawing.Size(142, 20);
            this.TXTgastomayos.TabIndex = 11;
            // 
            // CBXgastos
            // 
            this.CBXgastos.FormattingEnabled = true;
            this.CBXgastos.Location = new System.Drawing.Point(101, 32);
            this.CBXgastos.Name = "CBXgastos";
            this.CBXgastos.Size = new System.Drawing.Size(121, 21);
            this.CBXgastos.TabIndex = 12;
            // 
            // BTingresar
            // 
            this.BTingresar.Location = new System.Drawing.Point(171, 109);
            this.BTingresar.Name = "BTingresar";
            this.BTingresar.Size = new System.Drawing.Size(114, 23);
            this.BTingresar.TabIndex = 2;
            this.BTingresar.Text = "Ingresar";
            this.BTingresar.UseVisualStyleBackColor = true;
            this.BTingresar.Click += new System.EventHandler(this.BTingresar_Click);
            // 
            // FRGastosdiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRGastosdiarios";
            this.Text = "Gastos diarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTingresar;
        private System.Windows.Forms.TextBox TXTcantidaddias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBXgastos;
        private System.Windows.Forms.TextBox TXTgastomayos;
        private System.Windows.Forms.TextBox TXTdiamayor;
        private System.Windows.Forms.TextBox TXTtotalgastos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTnuevo;
        private System.Windows.Forms.Button BTsalir;
    }
}