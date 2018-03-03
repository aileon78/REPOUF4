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
    public partial class FAgregarAutor : Form
    {
        public FAgregarAutor()
        {
            InitializeComponent();
        }

        private void BTVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal mostrar = new FormPrincipal();
            mostrar.Show();
        }




        private void BTGuardar_Click(object sender, EventArgs e)
        {

            String nom, cognom;
            int edad;

            nom = TBNombre.Text;
            cognom = TBApellido.Text;
            edad = Convert.ToInt32(TBEdad.Text);

            Autor au = new Autor(nom,cognom,edad);

            au.escriuObjecteFitxer();

            limpiarCampos();

        }

        private void limpiarCampos()
        {
            TBNombre.Text = "";
            TBApellido.Text = "";
            TBEdad.Text = "";
        }



    }
}
