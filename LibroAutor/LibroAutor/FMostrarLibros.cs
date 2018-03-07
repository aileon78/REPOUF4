using LibroAutor.Clases;
using System;
using System.Windows.Forms;

namespace LibroAutor
{
    public partial class FMostrarLibros : Form
    {
        public FMostrarLibros()
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
        private void mostrar(Libro[] aut)
        {

            int i;
            int maxAut = contaVector(aut);
            for (i = 0; i < maxAut; i++)
            {
                mostrarAutor(aut[i]);

            }


        }
        private void mostrarAutor(Libro a)
        {
            RTBMostrarLibro.Text = RTBMostrarLibro.Text + "\nTitulo Libro: " + a.Titulo + "\nISBN: " + a.Isbn + "\nAutor :\n  -Nom Autor :" + a.Aut.Nom + "\n  -Cognom Autor: " + a.Aut.Cognom + "\n  -Edad Autor:" + a.Aut.Edad + "\n----------------------------------------------------\n";

        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FMostrarLibros_Load(object sender, EventArgs e)
        {
            Libro[] aut = new Libro[100];
            Libro a = new Libro();


            aut = a.llegirObjecteLibroFitxer();


            mostrar(aut);
        }
    }
}
