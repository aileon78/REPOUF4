using LibroAutor.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroAutor
{
    public partial class FMostrarAutor : Form
    {
        public FMostrarAutor()
        {
            InitializeComponent();
        }

        private void BTVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostrar = new FormPrincipal();

            mostrar.Show();
        }

        private int contaVector(Object[] obj)
        {

            int i = 0;
            do
            {
                if (obj[i] == null)
                    return i;
                i++;
            } while (i < obj.Length);

            return i;
        }


        private void mostrar(Autor[] aut) {

            int i;
            int maxAut = contaVector(aut);
            for (i = 0; i < maxAut; i++)
            {
                mostrarAutor(aut[i]);

            }


        }
        private void mostrarAutor(Autor a)
        {
            RTB1.Text=RTB1.Text + "\nNombre: "+ a.Nom+"\nApellido: "+a.Cognom+"\nEdad: "+a.Edad+"\n\n";

        }
        private void FMostrarAutor_Load(object sender, EventArgs e)
        {
            Autor[] aut = new Autor[100];
            Autor a = new Autor();


            aut = a.llegirObjecteFitxer();
            mostrar(aut);

        }

        private void RTB1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
