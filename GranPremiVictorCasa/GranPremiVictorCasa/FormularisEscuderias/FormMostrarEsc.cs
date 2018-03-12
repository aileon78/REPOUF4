using GranPremiVictorCasa.Clases;
using System;
using System.Windows.Forms;

namespace GranPremiVictorCasa
{
    public partial class FormMostrarEsc : Form
    {
        public FormMostrarEsc()
        {
            InitializeComponent();
        }



        private void devuelveEscuderia()
        {


        }

        private void mostrar()
        {

            Escuderia[] esc = new Escuderia[100];
            Escuderia es = new Escuderia();
            //String fitxer = "fitxer/llibres.dat";
            esc = es.llegeixFitxerEscuderia();
            int i = 0;
            do
            {
                RTB1.Text = RTB1.Text + "Nom Escuderia:  " + esc[i].NomEsc + "\nPais Escuderia:  " + esc[i].PaisEsc + "\nAny Fundacio:  " + esc[i].AnyEsc + "\nMotor (CC):  " + esc[i].MotorEsc + "\n\n";
                i++;
            } while (esc[i] != null);





        }

        private void FormMostrarEsc_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void BTTornar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostraprincipal = new FormPrincipal();
            mostraprincipal.Show();
        }
    }
}
