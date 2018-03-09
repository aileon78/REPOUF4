using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
