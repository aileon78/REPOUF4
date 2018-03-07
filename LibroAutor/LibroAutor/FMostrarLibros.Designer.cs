namespace LibroAutor
{
    partial class FMostrarLibros
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
            this.RTBMostrarLibro = new System.Windows.Forms.RichTextBox();
            this.BTVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBMostrarLibro
            // 
            this.RTBMostrarLibro.Location = new System.Drawing.Point(12, 12);
            this.RTBMostrarLibro.Name = "RTBMostrarLibro";
            this.RTBMostrarLibro.Size = new System.Drawing.Size(260, 192);
            this.RTBMostrarLibro.TabIndex = 0;
            this.RTBMostrarLibro.Text = "";
            // 
            // BTVolver
            // 
            this.BTVolver.Location = new System.Drawing.Point(99, 210);
            this.BTVolver.Name = "BTVolver";
            this.BTVolver.Size = new System.Drawing.Size(75, 23);
            this.BTVolver.TabIndex = 1;
            this.BTVolver.Text = "Volver";
            this.BTVolver.UseVisualStyleBackColor = true;
            this.BTVolver.Click += new System.EventHandler(this.BTVolver_Click);
            // 
            // FMostrarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTVolver);
            this.Controls.Add(this.RTBMostrarLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FMostrarLibros";
            this.Text = "FMostrarLibros";
            this.Load += new System.EventHandler(this.FMostrarLibros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBMostrarLibro;
        private System.Windows.Forms.Button BTVolver;
    }
}