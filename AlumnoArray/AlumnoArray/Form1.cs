using AlumnoArray.Clases;
using System;
using System.Windows.Forms;

namespace AlumnoArray
{
    public partial class Form1 : Form
    {
        static int max = 50;
        int cont = 0;
        Alumno[] vecAl = new Alumno[max];


        public Form1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            String nom, pcognom, scognom;
            int edad, nota;

            nom = TBNombre.Text;
            pcognom = TBApellido1.Text;
            scognom = TBApellido2.Text;
            edad = Convert.ToInt32(CBEdad.SelectedItem);
            nota = Convert.ToInt32(CBNota.SelectedItem);

            Alumno objAl = new Alumno(nom,pcognom,scognom,edad,nota);

            vecAl[cont]= objAl;
            cont++;

            limpiarDatos();


        }

        private void limpiarDatos()
        {
            TBNombre.Text = "";
            TBApellido1.Text = "";
            TBApellido2.Text = "";
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            int i;
            
            for ( i = 0; i < cont; i++)
            {
                RTB1.Text = RTB1.Text + "Nom ----------:"+vecAl[i].Nom+"\n" +
                    "Cognom 1 ---:"+vecAl[i].Pcognom+"\n" +
                    "Cognom 2 ---:"+vecAl[i].Scognom+"\n" +
                    "Edad ----------:"+vecAl[i].Edad+"\n"+
                    "Nota ----------:"+vecAl[i].Nota+"\n\n";
            }
        }
    }
}
