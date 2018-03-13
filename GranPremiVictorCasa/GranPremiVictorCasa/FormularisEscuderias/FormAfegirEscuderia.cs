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

namespace GranPremiVictorCasa
{
    public partial class FormAfegirEscuderia : Form
    {
        public FormAfegirEscuderia()
        {
            InitializeComponent();
        }

        private void BTTorna_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostraprincipal = new FormPrincipal();
            mostraprincipal.Show();

        }

        private void BTAfegir_Click(object sender, EventArgs e)
        {
            String nomEsc,paisEsc,motorEsc;
            int anyFund;


            nomEsc = TBNomEsc.Text;
            paisEsc = TBPais.Text;
            motorEsc = TBMotor.Text;
            anyFund = Convert.ToInt32(TBAnyFun.Text);

            Escuderia esc = new Escuderia(nomEsc,paisEsc,anyFund,motorEsc);

            esc.afegeixFitxerEscuderia();


            limpiarCampos();

        }

        private void limpiarCampos()
        {
            TBNomEsc.Text = "";
            TBPais.Text = "";
            TBAnyFun.Text = "";
            TBMotor.Text = "";
        }
        //private void tanca()
        //{
        //    FormPrincipal principal = new FormPrincipal();
        //    principal.Show();
        //}
        //private void FormAfegirEscuderia_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    tanca();
        //}

        private void FormAfegirEscuderia_Load(object sender, EventArgs e)
        {

        }
    }
}
