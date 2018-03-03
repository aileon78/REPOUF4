namespace Libros2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.BTMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBTitulo = new System.Windows.Forms.TextBox();
            this.TBAutor = new System.Windows.Forms.TextBox();
            this.TBContenido = new System.Windows.Forms.TextBox();
            this.TBAny = new System.Windows.Forms.TextBox();
            this.TBDimensiones = new System.Windows.Forms.TextBox();
            this.TBColorportada = new System.Windows.Forms.TextBox();
            this.TBNumpaginas = new System.Windows.Forms.TextBox();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.LBAutor = new System.Windows.Forms.Label();
            this.LBContenido = new System.Windows.Forms.Label();
            this.LBAny = new System.Windows.Forms.Label();
            this.LBDimensones = new System.Windows.Forms.Label();
            this.LBNumeroPaginas = new System.Windows.Forms.Label();
            this.LBColorportada = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBNumpaginas);
            this.groupBox1.Controls.Add(this.TBColorportada);
            this.groupBox1.Controls.Add(this.TBDimensiones);
            this.groupBox1.Controls.Add(this.TBAny);
            this.groupBox1.Controls.Add(this.TBContenido);
            this.groupBox1.Controls.Add(this.TBAutor);
            this.groupBox1.Controls.Add(this.TBTitulo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTGuardar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.LBColorportada);
            this.groupBox2.Controls.Add(this.LBNumeroPaginas);
            this.groupBox2.Controls.Add(this.LBDimensones);
            this.groupBox2.Controls.Add(this.LBAny);
            this.groupBox2.Controls.Add(this.LBContenido);
            this.groupBox2.Controls.Add(this.LBAutor);
            this.groupBox2.Controls.Add(this.LBTitulo);
            this.groupBox2.Controls.Add(this.BTMostrar);
            this.groupBox2.Location = new System.Drawing.Point(13, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BTGuardar
            // 
            this.BTGuardar.Location = new System.Drawing.Point(411, 168);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTGuardar.TabIndex = 0;
            this.BTGuardar.Text = "&GUARDAR";
            this.BTGuardar.UseVisualStyleBackColor = true;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // BTMostrar
            // 
            this.BTMostrar.Location = new System.Drawing.Point(411, 160);
            this.BTMostrar.Name = "BTMostrar";
            this.BTMostrar.Size = new System.Drawing.Size(75, 23);
            this.BTMostrar.TabIndex = 1;
            this.BTMostrar.Text = "&MOSTRAR";
            this.BTMostrar.UseVisualStyleBackColor = true;
            this.BTMostrar.Click += new System.EventHandler(this.BTMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contenido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dimensiones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Coloro portada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numero de paginas :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Año";
            // 
            // TBTitulo
            // 
            this.TBTitulo.Location = new System.Drawing.Point(25, 36);
            this.TBTitulo.Name = "TBTitulo";
            this.TBTitulo.Size = new System.Drawing.Size(100, 20);
            this.TBTitulo.TabIndex = 8;
            // 
            // TBAutor
            // 
            this.TBAutor.Location = new System.Drawing.Point(208, 36);
            this.TBAutor.Name = "TBAutor";
            this.TBAutor.Size = new System.Drawing.Size(100, 20);
            this.TBAutor.TabIndex = 9;
            // 
            // TBContenido
            // 
            this.TBContenido.Location = new System.Drawing.Point(386, 36);
            this.TBContenido.Name = "TBContenido";
            this.TBContenido.Size = new System.Drawing.Size(100, 20);
            this.TBContenido.TabIndex = 10;
            // 
            // TBAny
            // 
            this.TBAny.Location = new System.Drawing.Point(25, 100);
            this.TBAny.Name = "TBAny";
            this.TBAny.Size = new System.Drawing.Size(100, 20);
            this.TBAny.TabIndex = 11;
            // 
            // TBDimensiones
            // 
            this.TBDimensiones.Location = new System.Drawing.Point(208, 100);
            this.TBDimensiones.Name = "TBDimensiones";
            this.TBDimensiones.Size = new System.Drawing.Size(100, 20);
            this.TBDimensiones.TabIndex = 12;
            // 
            // TBColorportada
            // 
            this.TBColorportada.Location = new System.Drawing.Point(386, 100);
            this.TBColorportada.Name = "TBColorportada";
            this.TBColorportada.Size = new System.Drawing.Size(100, 20);
            this.TBColorportada.TabIndex = 13;
            // 
            // TBNumpaginas
            // 
            this.TBNumpaginas.Location = new System.Drawing.Point(133, 175);
            this.TBNumpaginas.Name = "TBNumpaginas";
            this.TBNumpaginas.Size = new System.Drawing.Size(100, 20);
            this.TBNumpaginas.TabIndex = 14;
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.Location = new System.Drawing.Point(22, 52);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(41, 13);
            this.LBTitulo.TabIndex = 8;
            this.LBTitulo.Text = "label14";
            // 
            // LBAutor
            // 
            this.LBAutor.AutoSize = true;
            this.LBAutor.Location = new System.Drawing.Point(205, 52);
            this.LBAutor.Name = "LBAutor";
            this.LBAutor.Size = new System.Drawing.Size(41, 13);
            this.LBAutor.TabIndex = 9;
            this.LBAutor.Text = "label13";
            // 
            // LBContenido
            // 
            this.LBContenido.AutoSize = true;
            this.LBContenido.Location = new System.Drawing.Point(385, 52);
            this.LBContenido.Name = "LBContenido";
            this.LBContenido.Size = new System.Drawing.Size(41, 13);
            this.LBContenido.TabIndex = 10;
            this.LBContenido.Text = "label12";
            // 
            // LBAny
            // 
            this.LBAny.AutoSize = true;
            this.LBAny.Location = new System.Drawing.Point(22, 102);
            this.LBAny.Name = "LBAny";
            this.LBAny.Size = new System.Drawing.Size(41, 13);
            this.LBAny.TabIndex = 11;
            this.LBAny.Text = "label11";
            // 
            // LBDimensones
            // 
            this.LBDimensones.AutoSize = true;
            this.LBDimensones.Location = new System.Drawing.Point(205, 111);
            this.LBDimensones.Name = "LBDimensones";
            this.LBDimensones.Size = new System.Drawing.Size(41, 13);
            this.LBDimensones.TabIndex = 12;
            this.LBDimensones.Text = "label10";
            // 
            // LBNumeroPaginas
            // 
            this.LBNumeroPaginas.AutoSize = true;
            this.LBNumeroPaginas.Location = new System.Drawing.Point(152, 165);
            this.LBNumeroPaginas.Name = "LBNumeroPaginas";
            this.LBNumeroPaginas.Size = new System.Drawing.Size(35, 13);
            this.LBNumeroPaginas.TabIndex = 13;
            this.LBNumeroPaginas.Text = "label9";
            // 
            // LBColorportada
            // 
            this.LBColorportada.AutoSize = true;
            this.LBColorportada.Location = new System.Drawing.Point(385, 111);
            this.LBColorportada.Name = "LBColorportada";
            this.LBColorportada.Size = new System.Drawing.Size(35, 13);
            this.LBColorportada.TabIndex = 14;
            this.LBColorportada.Text = "label8";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Año";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Numero de paginas :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(385, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Coloro portada";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(205, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Dimensiones";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(385, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Contenido";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(205, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Autor";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(22, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Titulo";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(22, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Titulo";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(205, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "Autor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBColorportada;
        private System.Windows.Forms.TextBox TBDimensiones;
        private System.Windows.Forms.TextBox TBAny;
        private System.Windows.Forms.TextBox TBContenido;
        private System.Windows.Forms.TextBox TBAutor;
        private System.Windows.Forms.TextBox TBTitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTMostrar;
        private System.Windows.Forms.TextBox TBNumpaginas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label LBColorportada;
        private System.Windows.Forms.Label LBNumeroPaginas;
        private System.Windows.Forms.Label LBDimensones;
        private System.Windows.Forms.Label LBAny;
        private System.Windows.Forms.Label LBContenido;
        private System.Windows.Forms.Label LBAutor;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
    }
}

