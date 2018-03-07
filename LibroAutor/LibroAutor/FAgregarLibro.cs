using LibroAutor.Clases;
using System;
using System.Windows.Forms;

namespace LibroAutor
{
    public partial class FAgregarLibro : Form
    {
        public FAgregarLibro()
        {
            InitializeComponent();
        }

        private void BTAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostrar = new FormPrincipal();

            mostrar.Show();
        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            String titol, isbn;



            Autor aut = new Autor();

            //recogeos los datos
            titol = TBNombreLibro.Text;
            isbn = TBIsbn.Text;

          
            //CBAutor.SelectedItem = aut;

            aut = aut.devuelveAutor(CBAutor.Text);




            Libro lb = new Libro(titol, isbn, aut);
            lb.afegeixObjecteLibroFitxer();





            limpiarCampos();





        }
        private void limpiarCampos()
        {
            TBIsbn.Text = "";
            TBNombreLibro.Text = "";
            CBAutor.Text = "";
        }


        //private int contarVector(Object[] obj)
        //{

        //    int i = 0;
        //    do
        //    {
        //        if (obj[i] != null)
        //        {
        //            i++;
        //        }
        //        else
        //        {
        //            return i;
        //        }

        //    } while (i < obj.Length);

        //    //aqui entraremos en el caso de que hayan 100 en el vector
        //    return i;


        //}

        //private void mostrarAutores(Autor[] au)
        //{

        //    int maxVec = contarVector(au);
        //    int i;
        //    for (i = 0; i < maxVec; i++)
        //    {
        //        //CBAutor.Text = CBAutor.Text + au[i].Nom ;
        //        CBAutor.Items.Add(au[i].Nom);

        //    }
        //}

        private void FAgregarLibro_Load(object sender, EventArgs e)
        {
            //Autor[] aut = new Autor[100];
            //Autor t = new Autor();

            //aut = t.llegirObjecteFitxer();

            //mostrarAutores(aut);
            Autor[] aut = new Autor[100];       // per crear un array d'autors
            Autor au = new Autor();             // per utilitzar el mètode (llegir objecteFitxer) dintre d'autor
            int i = 0;
            aut = au.llegirObjecteAutorFitxer();

            //////////////////////
            // Omplim el comboBox
            //////////////////////            
            //CBAutors.Items.Add("hola");
            //CBAutors.Items.Add("adeu");
            //CBAutors.Text="hola";
            do
            {
                CBAutor.Items.Add(aut[i].Nom);
                i++;
            } while (aut[i] != null);


            // Per a que hi haja un sel.leccionat
            CBAutor.Text = aut[0].Nom;

        }





    }
}
