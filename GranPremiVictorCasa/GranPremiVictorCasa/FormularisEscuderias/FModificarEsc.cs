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

namespace GranPremiVictorCasa.FormularisEscuderias
{
    public partial class FModificarEsc : Form
    {

        int numEsc = 0;

        public FModificarEsc()
        {
            InitializeComponent();
        }

        private void BTTornar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostraprincipal = new FormPrincipal();
            mostraprincipal.Show();
            //torna();
        }
        //private void FModificarEsc_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    FormPrincipal f = new FormPrincipal();
        //    f.Show();
        //}
        //public void torna()
        //{

        //    this.Close();

        //}
        private void BTModificar_Click(object sender, EventArgs e)
        {
            //Recogemos los datos para guardarlos en el objeto
            String nom,pais,motor;
            int any;
            nom = TBModNomEsc.Text;
            pais = TBModPaisEsc.Text;
            motor = TBModMotorEsc.Text;
            any = Convert.ToInt32(TBModAnyEsc.Text);

            //Construimos el objeto
            Escuderia esc = new Escuderia(nom,pais,any,motor);

            //modificamos la escuderia
            esc.modificarEscuderia();

            //Y volvemos al estado inicial
            numEsc = 0;
            carregaComboBox();
            Botonera();

        }

        private void Botonera()
        {
            Boolean primers, ultims = true;
            Escuderia esc = new Escuderia();
            int totalEsc = esc.contaEscuderies();

            // primers botons
            if (numEsc == 0)
                primers = false;
            else
                primers = true;

            // últims botons
            if (numEsc == totalEsc - 1)
                ultims = false;
            else
                ultims = true;


            // apliquem els enabled als botons
            BTPrimer.Enabled = primers;
            BTAnterior.Enabled = primers;
            BTSiguiente.Enabled = ultims;
            BTUltimo.Enabled = ultims;
        }

        private void carregaComboBox()
        {
            Escuderia[] esc = new Escuderia[100];
            Escuderia e1 = new Escuderia();
            esc = e1.llegeixFitxerEscuderia();

            // carreguem els comboBox amb la escuderia (i)
            TBModNomEsc.Text = esc[numEsc].NomEsc;
            TBModAnyEsc.Text = Convert.ToString(esc[numEsc].AnyEsc);
            TBModPaisEsc.Text = esc[numEsc].PaisEsc;
            TBModMotorEsc.Text = esc[numEsc].MotorEsc;
        }

        private void BTPrimer_Click(object sender, EventArgs e)
        {
            numEsc = 0;
            carregaComboBox();
            Botonera();
        }

        private void BTSiguiente_Click(object sender, EventArgs e)
        {
            numEsc++;
            carregaComboBox();
            Botonera();
        }

        private void BTUltimo_Click(object sender, EventArgs e)
        {
            Escuderia esc = new Escuderia();
            int totalEsc = esc.contaEscuderies();
            numEsc = totalEsc - 1;

            carregaComboBox();
            Botonera();
        }

        private void BTAnterior_Click(object sender, EventArgs e)
        {
            numEsc--;
            carregaComboBox();
            Botonera();
        }

        private void FModificarEsc_Load(object sender, EventArgs e)
        {
            // carreguem els comboBox amb la primera escuderia
            numEsc = 0;
            carregaComboBox();
            Botonera();
            TBModNomEsc.Enabled = false;

        }

    }
}
