using GranPremiVictorCasa.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranPremiVictorCasa.FormularisPilots
{
    public partial class FMostrarPilots : Form
    {
        public FMostrarPilots()
        {
            InitializeComponent();
        }

        private void BTTornar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostraprincipal = new FormPrincipal();
            mostraprincipal.Show();
        }

        private void FMostrarPilots_Load(object sender, EventArgs e)
        {
            pilot [] esc = new pilot[100];
            pilot es = new pilot();
            //String fitxer = "fitxer/llibres.dat";
            //esc = es.llegeixFitxerEscuderia();
            esc = es.llegeixPilotFitxer();
            int i = 0;
            do
            {
                RTBMostrarPil.Text = RTBMostrarPil.Text + "Nom Pilot:  " + esc[i].Nom + "\nPais :  " + esc[i].Nacionalitat + "\nDorsal:  " + esc[i].Dorsal + "\nEscuderia :  " + esc[i].Escu.NomEsc + "\n\n";
                i++;
            } while (esc[i] != null);
        }
    }
}
