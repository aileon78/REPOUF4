using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroAutor.Clases
{
    [Serializable]
    public class Libro
    {

        ///variables privadas
        private String titulo;
        private String isbn;
        private Autor aut;



        //constructores
        public Libro()
        {
        }

        public Libro(string titulo, string isbn, Autor aut)
        {
            this.Titulo = titulo;
            this.Isbn = isbn;
            this.Aut = aut;
        }


        //GETTERS Y SETTERS
        public string Titulo { get => titulo; set => titulo = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        internal Autor Aut { get => aut; set => aut = value; }



        //RESTO DE METODOS
        private FileMode modeApertura(Boolean afegir)
        {

            if (afegir)
                return FileMode.Append;
            else
                return FileMode.Create;
        }
        public void afegeixObjecteLibroFitxer(String arxiu = "fitxer/llibres.dat", Boolean afegir = true)
        {

            FileMode f = modeApertura(afegir);

            Stream str = File.Open(arxiu, f);


            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(str, this);
            str.Close();
        }



        public Libro[] llegirObjecteLibroFitxer(String fitxer = "fitxer/llibres.dat")
        {
            // //////////////////////// //
            // LLEGIR OBJECTE EN FITXER //
            // //////////////////////// //
            Stream str = File.Open(fitxer, FileMode.Open);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            int q = 0;
            Libro[] li = new Libro[100];
            //int numTreb = 0;
            do
            {
                try
                {
                    li[q] = (Libro)formatter.Deserialize(str);
                }
                catch
                {
                    //MessageBox.Show("Error al llegir el fitxer d'Objectes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                q++;
                //numTreb = q - 1;

            } while (li[q - 1] != null);

            str.Close();
            return li;
        }

    }
}
