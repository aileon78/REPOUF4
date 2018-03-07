namespace LibroAutor
{
    partial class FAgregarLibro
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
            this.TBNombreLibro = new System.Windows.Forms.TextBox();
            this.TBIsbn = new System.Windows.Forms.TextBox();
            this.CBAutor = new System.Windows.Forms.ComboBox();
            this.BTAtras = new System.Windows.Forms.Button();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // TBNombreLibro
            // 
            this.TBNombreLibro.Location = new System.Drawing.Point(124, 25);
            this.TBNombreLibro.Name = "TBNombreLibro";
            this.TBNombreLibro.Size = new System.Drawing.Size(100, 20);
            this.TBNombreLibro.TabIndex = 3;
            // 
            // TBIsbn
            // 
            this.TBIsbn.Location = new System.Drawing.Point(124, 66);
            this.TBIsbn.Name = "TBIsbn";
            this.TBIsbn.Size = new System.Drawing.Size(100, 20);
            this.TBIsbn.TabIndex = 4;
            // 
            // CBAutor
            // 
            this.CBAutor.FormattingEnabled = true;
            this.CBAutor.Location = new System.Drawing.Point(124, 113);
            this.CBAutor.Name = "CBAutor";
            this.CBAutor.Size = new System.Drawing.Size(121, 21);
            this.CBAutor.TabIndex = 5;
            // 
            // BTAtras
            // 
            this.BTAtras.Location = new System.Drawing.Point(170, 205);
            this.BTAtras.Name = "BTAtras";
            this.BTAtras.Size = new System.Drawing.Size(75, 23);
            this.BTAtras.TabIndex = 6;
            this.BTAtras.Text = "Atras";
            this.BTAtras.UseVisualStyleBackColor = true;
            this.BTAtras.Click += new System.EventHandler(this.BTAtras_Click);
            // 
            // BTGuardar
            // 
            this.BTGuardar.Location = new System.Drawing.Point(27, 205);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTGuardar.TabIndex = 7;
            this.BTGuardar.Text = "&Guardar";
            this.BTGuardar.UseVisualStyleBackColor = true;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // FAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.BTAtras);
            this.Controls.Add(this.CBAutor);
            this.Controls.Add(this.TBIsbn);
            this.Controls.Add(this.TBNombreLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAgregarLibro";
            this.Text = "FAgregarLibro";
            this.Load += new System.EventHandler(this.FAgregarLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNombreLibro;
        private System.Windows.Forms.TextBox TBIsbn;
        private System.Windows.Forms.ComboBox CBAutor;
        private System.Windows.Forms.Button BTAtras;
        private System.Windows.Forms.Button BTGuardar;
    }
}