using System;
using System.Windows.Forms;

namespace LibroAutor
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void añadirAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAgregarAutor mostrar = new FAgregarAutor();
            mostrar.Show();

        }

        private void mostrarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMostrarAutor mostrar = new FMostrarAutor();
            mostrar.Show();
        }

        private void añadirLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAgregarLibro mostrar = new FAgregarLibro();
            mostrar.Show();
        }
    }
}
