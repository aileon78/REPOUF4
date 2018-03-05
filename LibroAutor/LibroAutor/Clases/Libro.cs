using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroAutor.Clases
{
    [Serializable]
    public class Libro
    {

        ///variables privadas
        private String nom;
        private String isbn;
        private Autor aut;



        //constructores
        public Libro()
        {
        }

        public Libro(string nom, string isbn, Autor aut)
        {
            this.Nom = nom;
            this.Isbn = isbn;
            this.Aut = aut;
        }


        //GETTERS Y SETTERS
        public string Nom { get => nom; set => nom = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public Autor Aut { get => aut; set => aut = value; }



        //RESTO DE METODOS


    }
}
