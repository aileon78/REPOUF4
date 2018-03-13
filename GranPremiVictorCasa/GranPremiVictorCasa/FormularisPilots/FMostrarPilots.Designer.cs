namespace GranPremiVictorCasa.FormularisPilots
{
    partial class FMostrarPilots
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
            this.RTBMostrarPil = new System.Windows.Forms.RichTextBox();
            this.BTTornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBMostrarPil
            // 
            this.RTBMostrarPil.Location = new System.Drawing.Point(13, 13);
            this.RTBMostrarPil.Name = "RTBMostrarPil";
            this.RTBMostrarPil.Size = new System.Drawing.Size(259, 183);
            this.RTBMostrarPil.TabIndex = 0;
            this.RTBMostrarPil.Text = "";
            // 
            // BTTornar
            // 
            this.BTTornar.Location = new System.Drawing.Point(101, 212);
            this.BTTornar.Name = "BTTornar";
            this.BTTornar.Size = new System.Drawing.Size(75, 23);
            this.BTTornar.TabIndex = 1;
            this.BTTornar.Text = "Tornar";
            this.BTTornar.UseVisualStyleBackColor = true;
            this.BTTornar.Click += new System.EventHandler(this.BTTornar_Click);
            // 
            // FMostrarPilots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTTornar);
            this.Controls.Add(this.RTBMostrarPil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FMostrarPilots";
            this.Text = "FMostrarpilots";
            this.Load += new System.EventHandler(this.FMostrarPilots_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBMostrarPil;
        private System.Windows.Forms.Button BTTornar;
    }
}