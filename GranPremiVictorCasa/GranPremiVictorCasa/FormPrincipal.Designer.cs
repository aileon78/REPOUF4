﻿namespace GranPremiVictorCasa
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
            this.escuderiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afegirEscuderiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEscuderiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEscueriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mostrarEscuderiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afegeixPilotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaPilotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaPilotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mostrarPilotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilotsToolStripMenuItem,
            this.escuderiasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // escuderiasToolStripMenuItem
            // 
            this.escuderiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afegirEscuderiaToolStripMenuItem,
            this.modificarEscuderiaToolStripMenuItem,
            this.eliminarEscueriaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mostrarEscuderiaToolStripMenuItem});
            this.escuderiasToolStripMenuItem.Name = "escuderiasToolStripMenuItem";
            this.escuderiasToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.escuderiasToolStripMenuItem.Text = "Escuderies";
            // 
            // afegirEscuderiaToolStripMenuItem
            // 
            this.afegirEscuderiaToolStripMenuItem.Name = "afegirEscuderiaToolStripMenuItem";
            this.afegirEscuderiaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.afegirEscuderiaToolStripMenuItem.Text = "Afegir Escuderia";
            this.afegirEscuderiaToolStripMenuItem.Click += new System.EventHandler(this.afegirEscuderiaToolStripMenuItem_Click);
            // 
            // modificarEscuderiaToolStripMenuItem
            // 
            this.modificarEscuderiaToolStripMenuItem.Name = "modificarEscuderiaToolStripMenuItem";
            this.modificarEscuderiaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.modificarEscuderiaToolStripMenuItem.Text = "Modificar Escuderia";
            this.modificarEscuderiaToolStripMenuItem.Click += new System.EventHandler(this.modificarEscuderiaToolStripMenuItem_Click);
            // 
            // eliminarEscueriaToolStripMenuItem
            // 
            this.eliminarEscueriaToolStripMenuItem.Name = "eliminarEscueriaToolStripMenuItem";
            this.eliminarEscueriaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarEscueriaToolStripMenuItem.Text = "Eliminar Escueria";
            this.eliminarEscueriaToolStripMenuItem.Click += new System.EventHandler(this.eliminarEscueriaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // mostrarEscuderiaToolStripMenuItem
            // 
            this.mostrarEscuderiaToolStripMenuItem.Name = "mostrarEscuderiaToolStripMenuItem";
            this.mostrarEscuderiaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.mostrarEscuderiaToolStripMenuItem.Text = "Mostrar Escuderia";
            this.mostrarEscuderiaToolStripMenuItem.Click += new System.EventHandler(this.mostrarEscuderiaToolStripMenuItem_Click);
            // 
            // pilotsToolStripMenuItem
            // 
            this.pilotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afegeixPilotToolStripMenuItem,
            this.modificaPilotToolStripMenuItem,
            this.eliminaPilotToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mostrarPilotsToolStripMenuItem});
            this.pilotsToolStripMenuItem.Name = "pilotsToolStripMenuItem";
            this.pilotsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.pilotsToolStripMenuItem.Text = "Pilots";
            // 
            // afegeixPilotToolStripMenuItem
            // 
            this.afegeixPilotToolStripMenuItem.Name = "afegeixPilotToolStripMenuItem";
            this.afegeixPilotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afegeixPilotToolStripMenuItem.Text = "Afegeix Pilot";
            this.afegeixPilotToolStripMenuItem.Click += new System.EventHandler(this.afegeixPilotToolStripMenuItem_Click);
            // 
            // modificaPilotToolStripMenuItem
            // 
            this.modificaPilotToolStripMenuItem.Name = "modificaPilotToolStripMenuItem";
            this.modificaPilotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificaPilotToolStripMenuItem.Text = "Modifica Pilot";
            this.modificaPilotToolStripMenuItem.Click += new System.EventHandler(this.modificaPilotToolStripMenuItem_Click);
            // 
            // eliminaPilotToolStripMenuItem
            // 
            this.eliminaPilotToolStripMenuItem.Name = "eliminaPilotToolStripMenuItem";
            this.eliminaPilotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminaPilotToolStripMenuItem.Text = "Elimina Pilot";
            this.eliminaPilotToolStripMenuItem.Click += new System.EventHandler(this.eliminaPilotToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mostrarPilotsToolStripMenuItem
            // 
            this.mostrarPilotsToolStripMenuItem.Name = "mostrarPilotsToolStripMenuItem";
            this.mostrarPilotsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostrarPilotsToolStripMenuItem.Text = "Mostrar Pilots";
            this.mostrarPilotsToolStripMenuItem.Click += new System.EventHandler(this.mostrarPilotsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GranPremiVictorCasa.Properties.Resources.gp;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "F1 2018";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem escuderiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afegirEscuderiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEscuderiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEscueriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEscuderiaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pilotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afegeixPilotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaPilotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaPilotToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mostrarPilotsToolStripMenuItem;
    }
}

