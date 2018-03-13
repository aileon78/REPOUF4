using GranPremiVictorCasa.FormularisEscuderias;
using GranPremiVictorCasa.FormularisPilots;
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

        private void afegeixPilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAfegeixPilot mostrar = new FAfegeixPilot();
            mostrar.Show();
        }

        private void mostrarPilotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMostrarPilots mostra = new FMostrarPilots();
            mostra.Show();

        }

        private void eliminaPilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FEliminaPilot mostrar = new FEliminaPilot();
            mostrar.Show();
        }

        private void modificaPilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FModificarPilot mostrar = new FModificarPilot();
            mostrar.Show();
        }
    }
}
