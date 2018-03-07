using System;
using System.IO;

namespace LibroAutor.Clases
{
    [Serializable]
    public class Autor
    {

        //variables privadas
        private String nom;
        private String cognom;
        private int edad;





        //constructores
        public Autor()
        {
        }

        public Autor(string nom, string cognom, int edad)
        {
            this.Nom = nom;
            this.Cognom = cognom;
            this.Edad = edad;
        }


        //geters sters, metodos
        public string Nom { get => nom; set => nom = value; }
        public string Cognom { get => cognom; set => cognom = value; }
        public int Edad { get => edad; set => edad = value; }


        /// <summary>
        /// Conta els treballadors d'un vector d'objectes treballadors
        /// </summary>
        /// <param name="t">Array d'objectes treballadors</param>
        /// <returns>Número de treballadors (Objectes no nulls)</returns>
        //public int contaTreballadors(Autor[] a)
        //{
        //    // conta el número de treballadors
        //    // que hi han dintre del vector
        //    int total = -1;

        //    do
        //    {
        //        total++;
        //    } while (a[total] != null);

        //    return total;
        //}



        /// <summary>
        /// Entra un boolea afegir i ens retornarà el mode d'escriptura
        /// Si hem d'afegir al fitxer o si hem de reescriure'l      
        /// </summary>
        /// <param name="afegir">Booleà. True=afegir. False=reescriure</param>
        /// <returns>Variable de tipus FileMode indicant si afegim o reescrivim</returns>
        //private FileMode formaEscriptura(Boolean afegir)
        //{
        //    /////////////////////////////////////////////////
        //    // PER MIRAR DE QUINA FORMA OBRIM EL FITXER
        //    // SI AFEGINT O SOBREESCRIVINT
        //    // AMB EL PARÀMETRE "afegeix" PASSAT PER CAPÇALERA FUNCIÓ
        //    FileMode f = new FileMode();
        //    //
        //    if (afegir)
        //    {
        //        f = FileMode.Append;
        //    }
        //    else
        //    {
        //        f = FileMode.Create;
        //    }
        //    return f;
        //}





        /// <summary>
        /// Escrivim l'Objecte treballador al fitxer
        /// </summary>
        /// <param name="fitxer"></param>
        /// <param name="afegir">Booleà que ens indicarà si afegim al fitxer o si reescrivim
        /// <para>Utilitzarem la funció<see cref="formaEscriptura(bool)"/>
        /// </para></param>
        public void escriuObjecteAutorFitxer(String fitxer = "fitxer/autor.dat", bool afegir = true)
        {

            // Per poder utilitzar el paràmetre boolea afegir
            FileMode apertura = new FileMode();
            if (afegir)
                apertura = FileMode.Append;
            else
                apertura = FileMode.Create;

            Stream str = File.Open(fitxer, apertura);
            //Stream str = File.Open(fitxer, FileMode.Append);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(str, this);
            str.Close();
        }






        /// <summary>
        /// Llegeix un fitxer stream amb referències de treballadors
        /// I els encapsula dintre d'un array d'objectes treballador
        /// 
        /// </summary>
        /// <param name="fitxer">Ruta del fitxer</param>
        /// <returns>Array de Treballadors amb el contingut del fitxer</returns>
        public Autor[] llegirObjecteAutorFitxer(String fitxer = "fitxer/autor.dat")
        {
            // //////////////////////// //
            // LLEGIR OBJECTE EN FITXER //
            // //////////////////////// //
            Stream str = File.Open(fitxer, FileMode.Open);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            int q = 0;
            Autor[] aut = new Autor[100];
            //int numTreb = 0;
            do
            {
                try
                {
                    aut[q] = (Autor)formatter.Deserialize(str);
                }
                catch
                {
                    //MessageBox.Show("Error al llegir el fitxer d'Objectes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                q++;
                //numTreb = q - 1;

            } while (aut[q - 1] != null);

            str.Close();
            return aut;
        }

        /// <summary>
        /// //GUARDAREMOS LOS DATOS DE TIPO AUTOR 
        /// </summary>
        /// <param name="fitxer"></param>
        /// <returns></returns>
        public Autor devuelveAutor(String nomAutor, String fitxer = "fitxer/autor.dat")
        {
            // retorna un objecte autor si el troba
            // en cas que no trobe res torna un null

            Autor[] aut = new Autor[100];
            int i = 0;

            // llegim el fitxer d'autors
            aut = llegirObjecteAutorFitxer(fitxer);

            do
            {
                if (aut[i].nom.Equals(nomAutor))
                    return aut[i];
                i++;
            } while (aut[i] != null);
            return null;
        }



    }
}
