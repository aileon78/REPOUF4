namespace PruebasVectores
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
            this.CBXMostrar = new System.Windows.Forms.ComboBox();
            this.BTCargar = new System.Windows.Forms.Button();
            this.TBTitulo = new System.Windows.Forms.TextBox();
            this.TBAutor = new System.Windows.Forms.TextBox();
            this.TBNumeropaginas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBTamanyo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBXMostrar
            // 
            this.CBXMostrar.FormattingEnabled = true;
            this.CBXMostrar.Location = new System.Drawing.Point(49, 241);
            this.CBXMostrar.Name = "CBXMostrar";
            this.CBXMostrar.Size = new System.Drawing.Size(353, 21);
            this.CBXMostrar.TabIndex = 0;
            this.CBXMostrar.SelectedIndexChanged += new System.EventHandler(this.CBXMostrar_SelectedIndexChanged);
            // 
            // BTCargar
            // 
            this.BTCargar.Location = new System.Drawing.Point(282, 15);
            this.BTCargar.Name = "BTCargar";
            this.BTCargar.Size = new System.Drawing.Size(120, 23);
            this.BTCargar.TabIndex = 1;
            this.BTCargar.Text = "Cargar";
            this.BTCargar.UseVisualStyleBackColor = true;
            this.BTCargar.Click += new System.EventHandler(this.BTCargar_Click);
            // 
            // TBTitulo
            // 
            this.TBTitulo.Location = new System.Drawing.Point(133, 46);
            this.TBTitulo.Name = "TBTitulo";
            this.TBTitulo.Size = new System.Drawing.Size(100, 20);
            this.TBTitulo.TabIndex = 2;
            // 
            // TBAutor
            // 
            this.TBAutor.Location = new System.Drawing.Point(133, 83);
            this.TBAutor.Name = "TBAutor";
            this.TBAutor.Size = new System.Drawing.Size(100, 20);
            this.TBAutor.TabIndex = 3;
            // 
            // TBNumeropaginas
            // 
            this.TBNumeropaginas.Location = new System.Drawing.Point(133, 122);
            this.TBNumeropaginas.Name = "TBNumeropaginas";
            this.TBNumeropaginas.Size = new System.Drawing.Size(100, 20);
            this.TBNumeropaginas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero paginas";
            // 
            // TBTamanyo
            // 
            this.TBTamanyo.Location = new System.Drawing.Point(150, 12);
            this.TBTamanyo.Name = "TBTamanyo";
            this.TBTamanyo.Size = new System.Drawing.Size(100, 20);
            this.TBTamanyo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dime cuantos quieres ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBTamanyo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBNumeropaginas);
            this.Controls.Add(this.TBAutor);
            this.Controls.Add(this.TBTitulo);
            this.Controls.Add(this.BTCargar);
            this.Controls.Add(this.CBXMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBXMostrar;
        private System.Windows.Forms.Button BTCargar;
        private System.Windows.Forms.TextBox TBTitulo;
        private System.Windows.Forms.TextBox TBAutor;
        private System.Windows.Forms.TextBox TBNumeropaginas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBTamanyo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

