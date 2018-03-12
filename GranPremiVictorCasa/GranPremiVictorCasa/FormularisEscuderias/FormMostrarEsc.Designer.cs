namespace GranPremiVictorCasa
{
    partial class FormMostrarEsc
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
            this.BTTornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(12, 21);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(260, 183);
            this.RTB1.TabIndex = 0;
            this.RTB1.Text = "";
            // 
            // BTTornar
            // 
            this.BTTornar.Location = new System.Drawing.Point(101, 226);
            this.BTTornar.Name = "BTTornar";
            this.BTTornar.Size = new System.Drawing.Size(75, 23);
            this.BTTornar.TabIndex = 1;
            this.BTTornar.Text = "Tornar";
            this.BTTornar.UseVisualStyleBackColor = true;
            this.BTTornar.Click += new System.EventHandler(this.BTTornar_Click);
            // 
            // FormMostrarEsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTTornar);
            this.Controls.Add(this.RTB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMostrarEsc";
            this.Text = "FormMostrarEsc";
            this.Load += new System.EventHandler(this.FormMostrarEsc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.Button BTTornar;
    }
}