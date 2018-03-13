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
    public partial class FAfegeixPilot : Form
    {
        public FAfegeixPilot()
        {
            InitializeComponent();
        }

        private void BTTornar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostraprincipal = new FormPrincipal();
            mostraprincipal.Show();
        }

        private void BTAfegir_Click(object sender, EventArgs e)
        {
            //variables para recoger los datos
            String nom, nacionalitat;
            int dorsal;
            Escuderia esc = new Escuderia();


            //recogemos los datos y los guardamos dentro de las variables
            nom = TBNompilot.Text;
            nacionalitat = TBNacionalitat.Text;
            dorsal = Convert.ToInt32(TBDorsal.Text);
            //recogemos la variable tipo objeto
            esc = esc.cercarEscuderia(CBEscuderia.Text);

            //creamos el objetos de variables y objetos
            pilot pi = new pilot(nom, nacionalitat, dorsal, esc);

            //añadimos la variable objeto tipo pilot "pi" dentro del fichero

            pi.afegeixPilotFitxer();


            //vaciamos los texbox
            TBNompilot.Text = "";
            TBNacionalitat.Text = "";
            TBDorsal.Text = "";
            

        }

        ///A continuacion dentro del "LOAD" cargaremos el combobox de escuderias
        private void FAfegeixPilot_Load(object sender, EventArgs e)
        {
            Escuderia[] esc = new Escuderia[100];       // per crear un array d'autors
            Escuderia es = new Escuderia();             // per utilitzar el mètode (llegir objecteFitxer) dintre d'autor
            int i = 0;
            esc = es.llegeixFitxerEscuderia();

            //////////////////////
            // Omplim el comboBox
            //////////////////////            
            //CBAutors.Items.Add("hola");
            //CBAutors.Items.Add("adeu");
            //CBAutors.Text="hola";
            do
            {
                CBEscuderia.Items.Add(esc[i].NomEsc);
                i++;
            } while (esc[i] != null);


            // Per a que hi haja un sel.leccionat
            CBEscuderia.Text = esc[0].NomEsc;
        }



        private void tanca()
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }
        private void FAfegeixPilot_FormClosing(object sender, FormClosingEventArgs e)
        {

            tanca();
        }


    }
}
