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
    public partial class FModificarPilot : Form
    {

        int numPil = 0;

        public FModificarPilot()
        {
            InitializeComponent();
        }

        private void BTTorna_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostraprincipal = new FormPrincipal();
            mostraprincipal.Show();
        }

        private void FModificarPilot_Load(object sender, EventArgs e)
        {
            numPil = 0;
            carregaComboBox();
            Botonera();
            TBModNomPilot.Enabled = false;

            ////----------------------------------------------
            




        }

        private void carregaComboBox()
        {
            pilot[] pil = new pilot[100];
            pilot p1 = new pilot();
            pil = p1.llegeixPilotFitxer();

            // carreguem els comboBox amb la escuderia (i)
            TBModNomPilot.Text = pil[numPil].Nom;
            TBModDorsal.Text = Convert.ToString(pil[numPil].Dorsal);
            TBModNacionalitat.Text = pil[numPil].Nacionalitat;
            CBModEscuderiaPilot.Text = pil[numPil].Escu.NomEsc;
        }


        ///BOTONERA
        private void Botonera()
        {
            Boolean primers, ultims = true;
        pilot pil = new pilot();
        int totalEsc = pil.contaPilots();

            // primers botons
            if (numPil == 0)
                primers = false;
            else
                primers = true;

            // últims botons
            if (numPil == totalEsc - 1)
                ultims = false;
            else
                ultims = true;


            // apliquem els enabled als botons
            BTPrimer.Enabled = primers;
            BTAnterior.Enabled = primers;
            BTSeguent.Enabled = ultims;
            BTUltim.Enabled = ultims;
        }

        private void BTPrimer_Click(object sender, EventArgs e)
        {
            numPil = 0;
            carregaComboBox();
            Botonera();
        }

        private void BTAnterior_Click(object sender, EventArgs e)
        {
            numPil--;
            carregaComboBox();
            Botonera();
        }

        private void BTSeguent_Click(object sender, EventArgs e)
        {
            numPil++;
            carregaComboBox();
            Botonera();
        }

        private void BTUltim_Click(object sender, EventArgs e)
        {
            pilot pil = new pilot();
            int totalPil = pil.contaPilots();
            numPil = totalPil - 1;

            carregaComboBox();
            Botonera();
        }

        private void BTModifica_Click(object sender, EventArgs e)
        {
            //Recogemos los datos para guardarlos en el objeto
            String nom, nacionalitat, motor;
            int dorsal;
            Escuderia esc = new Escuderia();

            nom = TBModNomPilot.Text;
            nacionalitat = TBModNacionalitat.Text;
            dorsal = Convert.ToInt32(TBModDorsal.Text);

            esc = esc.cercarEscuderia(CBModEscuderiaPilot.Text);

            //creamos el objetos de variables y objetos
            pilot pi = new pilot(nom, nacionalitat, dorsal, esc);

            //añadimos la variable objeto tipo pilot "pi" dentro del fichero

            pi.afegeixPilotFitxer();

            //Construimos el objeto
            //Escuderia esc = new Escuderia(nom, nacionalitat, dorsal, motor);

            //modificamos la escuderia
            //esc.modificarEscuderia();

            //Y volvemos al estado inicial
            numPil = 0;
            carregaComboBox();
            Botonera();





        }
    }
}
