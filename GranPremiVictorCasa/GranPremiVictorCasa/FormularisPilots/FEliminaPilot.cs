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
    public partial class FEliminaPilot : Form
    {
        public FEliminaPilot()
        {
            InitializeComponent();
        }

        private void BTTornar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostraprincipal = new FormPrincipal();
            mostraprincipal.Show();
        }
        private void mostrarLabels(pilot pil, String nomEs)
        {
            // Introduïm en els labels si existeix la escuderia que hem buscat
            if (pil == null)
            {
                MessageBox.Show("No existeix la escuderia" + nomEs, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LBNomPilot.Text = pil.Nom;
                LBNacionalitatPilot.Text = pil.Nacionalitat;
                LBEscuderiaPilot.Text = pil.Escu.NomEsc;
                LBDorsalPilot.Text = Convert.ToString(pil.Dorsal);
            }

        }

        private void BTBuscaPilot_Click(object sender, EventArgs e)
        {
            //Recogemos los datos(nom escuderia)
            String nomPilot;
            nomPilot = TBNompilot.Text;
            //Creamos el objeto
            pilot pil = new pilot();

            //buscamos la escuderia 
            pil = pil.cercarPilot(nomPilot);


            TBNompilot.Text = pil.Nom;

            mostrarLabels(pil, nomPilot);
        }

        private void BTEliminaPilot_Click(object sender, EventArgs e)
        {
            if (LBNomPilot.Text != ":")
            {
                /////////////////////////
                /// FORMA 1. ELIMINA A PARTIR DEL NOM DE L'ESCUDERIA
                pilot pil = new pilot();
                pil.eliminaPilot(LBNomPilot.Text);

                /////////////////////////

                //// FORMA 2. ELIMINAR A PARTIR DE L'OBJECTE //
                ////CONSTRUÏM OBJECTE
                //String escuderia, pais, motor;
                //int any;

                //escuderia = LBEscuderia.Text;
                //pais = LBPais.Text;
                //motor = LBMotor.Text;
                //any = Convert.ToInt32(LBAny.Text);

                //escuderia es = new escuderia(escuderia, pais, any, motor);

                //es.eliminaEscuderia();

                // tornem les labels a la situació inicial
                LBNomPilot.Text = ":";
                LBNacionalitatPilot.Text = ":";
                LBEscuderiaPilot.Text = ":";
                LBDorsalPilot.Text = ":";
                TBNompilot.Text = "";


            }
        }
    }
}
