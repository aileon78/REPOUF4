namespace LibroAutor
{
    partial class FMostrarAutor
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
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.BTVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(75, 34);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(132, 167);
            this.RTB1.TabIndex = 0;
            this.RTB1.Text = "";
            // 
            // BTVolver
            // 
            this.BTVolver.Location = new System.Drawing.Point(104, 226);
            this.BTVolver.Name = "BTVolver";
            this.BTVolver.Size = new System.Drawing.Size(75, 23);
            this.BTVolver.TabIndex = 1;
            this.BTVolver.Text = "Volver";
            this.BTVolver.UseVisualStyleBackColor = true;
            this.BTVolver.Click += new System.EventHandler(this.BTVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 236);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FMostrarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTVolver);
            this.Controls.Add(this.RTB1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FMostrarAutor";
            this.Text = "FMostrarAutor";
            this.Load += new System.EventHandler(this.FMostrarAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.Button BTVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}