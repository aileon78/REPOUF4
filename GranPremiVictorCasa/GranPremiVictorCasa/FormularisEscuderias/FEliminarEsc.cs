using GranPremiVictorCasa.Clases;
using System;
using System.Windows.Forms;

namespace GranPremiVictorCasa.FormularisEscuderias
{
    public partial class FEliminarEsc : Form
    {
        public FEliminarEsc()
        {
            InitializeComponent();
        }

        private void LBAnyFElimina_Click(object sender, EventArgs e)
        {

        }

        private void BTTornar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostraprincipal = new FormPrincipal();
            mostraprincipal.Show();

        }
       

        private void mostrarLabels(Escuderia esc,String nomEs)
        {
            // Introduïm en els labels si existeix la escuderia que hem buscat
            if (esc == null)
            {
                MessageBox.Show("No existeix la escuderia" + nomEs, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LBNomEscElimEsc.Text = esc.NomEsc;
                LBMotorFElimi.Text = esc.MotorEsc;
                LBPaisFElim.Text = esc.PaisEsc;
                LBAnyFElimina.Text = Convert.ToString(esc.AnyEsc);
            }
        
        }
        private void BTBuscarEsc_Click(object sender, EventArgs e)
        {
            //Recogemos los datos(nom escuderia)
            String nomEsc;
            nomEsc = TBNomEscEliminaEsc.Text;
            //Creamos el objeto
            Escuderia esc = new Escuderia();

            //buscamos la escuderia 
            esc=esc.cercarEscuderia(nomEsc);


            LBNomEscElimEsc.Text = esc.NomEsc;

            mostrarLabels(esc,nomEsc);



            //// recollim dades
            //String nom_esc = TBBuscaEscuderia.Text;

            //// Creem l'objecte
            //escuderia esc = new escuderia();

            //// Cerquem la escuderia
            //esc = esc.CercaEscuderia(nom_esc);


            //// Introduïm en els labels si existeix la escuderia que hem buscat
            //if (esc == null)
            //{
            //    MessageBox.Show("No existeix la escuderia" + nom_esc, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    LBEscuderia.Text = esc.Nom;
            //    LBMotor.Text = esc.Motor;
            //    LBPais.Text = esc.Pais;
            //    LBAny.Text = Convert.ToString(esc.Any_fundacio);
            //}



        }

        private void BTEliminarEsc_Click(object sender, EventArgs e)
        {
            if (LBNomEscElimEsc.Text != ":")
            {
                /////////////////////////
                /// FORMA 1. ELIMINA A PARTIR DEL NOM DE L'ESCUDERIA
                Escuderia esc = new Escuderia();
                esc.eliminaEscuderia(LBNomEscElimEsc.Text);

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
                LBNomEscElimEsc.Text = ":";
                LBAnyFElimina.Text = ":";
                LBMotorFElimi.Text = ":";
                LBPaisFElim.Text = ":";
                TBNomEscEliminaEsc.Text = "";


            }
        }
    }
}
