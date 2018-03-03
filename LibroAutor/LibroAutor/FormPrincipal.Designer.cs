namespace LibroAutor
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libroToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirLibroToolStripMenuItem,
            this.mostrarLibroToolStripMenuItem});
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.libroToolStripMenuItem.Text = "Libro";
            // 
            // añadirLibroToolStripMenuItem
            // 
            this.añadirLibroToolStripMenuItem.Name = "añadirLibroToolStripMenuItem";
            this.añadirLibroToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.añadirLibroToolStripMenuItem.Text = "Añadir Libro";
            // 
            // mostrarLibroToolStripMenuItem
            // 
            this.mostrarLibroToolStripMenuItem.Name = "mostrarLibroToolStripMenuItem";
            this.mostrarLibroToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.mostrarLibroToolStripMenuItem.Text = "Mostrar Libro";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirAutorToolStripMenuItem,
            this.mostrarAutorToolStripMenuItem});
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.autorToolStripMenuItem.Text = "Autor";
            // 
            // añadirAutorToolStripMenuItem
            // 
            this.añadirAutorToolStripMenuItem.Name = "añadirAutorToolStripMenuItem";
            this.añadirAutorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.añadirAutorToolStripMenuItem.Text = "Añadir autor";
            this.añadirAutorToolStripMenuItem.Click += new System.EventHandler(this.añadirAutorToolStripMenuItem_Click);
            // 
            // mostrarAutorToolStripMenuItem
            // 
            this.mostrarAutorToolStripMenuItem.Name = "mostrarAutorToolStripMenuItem";
            this.mostrarAutorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostrarAutorToolStripMenuItem.Text = "Mostrar autor";
            this.mostrarAutorToolStripMenuItem.Click += new System.EventHandler(this.mostrarAutorToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LibroAutor.Properties.Resources.libreria;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 319);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarAutorToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

