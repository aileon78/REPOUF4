using GranPremiVictorCasa.FormularisEscuderias;
using System;
using System.Windows.Forms;

namespace GranPremiVictorCasa
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void afegirEscuderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAfegirEscuderia mostrar = new FormAfegirEscuderia();
            mostrar.Show();
        }

        private void mostrarEscuderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMostrarEsc mostrar = new FormMostrarEsc();
            mostrar.Show();

        }

        private void eliminarEscueriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            FEliminarEsc mostrar = new FEliminarEsc();
            mostrar.Show();
        }

        private void modificarEscuderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FModificarEsc mostrar = new FModificarEsc();
            mostrar.Show();
        }
    }
}
