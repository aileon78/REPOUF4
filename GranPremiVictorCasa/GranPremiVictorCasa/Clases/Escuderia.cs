using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranPremiVictorCasa.Clases
{
    [Serializable]
    public class Escuderia
    {
        //variables privadas
        private String nomEsc;
        private String paisEsc;
        private int anyEsc;
        private String motorEsc;

        //Constructores
        public Escuderia()
        {
        }

        public Escuderia(string nomEsc, string paisEsc, int anyEsc, String motorEsc)
        {
            this.nomEsc = nomEsc;
            this.paisEsc = paisEsc;
            this.anyEsc = anyEsc;
            this.motorEsc = motorEsc;
        }

        //GETTERS Y SETTERS
        public string NomEsc { get => nomEsc; set => nomEsc = value; }
        public string PaisEsc { get => paisEsc; set => paisEsc = value; }
        public int AnyEsc { get => anyEsc; set => anyEsc = value; }
        public string MotorEsc { get => motorEsc; set => motorEsc = value; }


        //RESTA DE Mètodes

            /// <summary>
            /// PARA AÑADIR ESCUDERIAS
            /// </summary>
            /// <param name="fitxer"></param>
            /// <param name="afegir"></param>
        public void afegeixFitxerEscuderia(String fitxer = "fitxer/escuderia.dat", bool afegir = true)
        {

            // Per poder utilitzar el paràmetre boolea afegir
            FileMode apertura = new FileMode();

            if (afegir)
                apertura = FileMode.Append;
            else
                apertura = FileMode.Create;


            //Stream str = File.Open(fitxer, FileMode.Append);
            Stream str = File.Open(fitxer, apertura);


            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(str, this);
            str.Close();

        }
        /// <summary>
        /// PARA LEER LAS ESCUDERIAS
        /// </summary>
        /// <param name="arxiu"></param>
        /// <returns></returns>
        public Escuderia[] llegirFitxerEscuderies(String arxiu = "fitxer/escuderia.dat")
        {
            // //////////////////////// //
            // LLEGIR OBJECTE EN FITXER //
            // //////////////////////// //
            Stream str = File.Open(arxiu, FileMode.Open);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            int q = 0;
            Escuderia[] esc = new Escuderia[100];

            do
            {
                try
                {
                    esc[q] = (Escuderia)formatter.Deserialize(str);
                }
                catch
                {
                    //MessageBox.Show("Error al llegir el fitxer d'Objectes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                q++;
            } while (esc[q - 1] != null);

            str.Close();
            return esc;
        }

        /// <summary>
        /// PARA BUSCAR LA ESCUDERIA Y RETORNARLA
        /// </summary>
        /// <param name="nomAutor"></param>
        /// <param name="fitxer"></param>
        /// <returns></returns>
        public Escuderia cercarAutor(String nomEsc, String fitxer = "fitxer/escuderia.dat")
        {
            // retorna un objecte autor si el troba
            // en cas que no trobe res torna un null

            Escuderia[] esc = new Escuderia[100];
            int i = 0;

            // llegim el fitxer d'autors
            esc = llegirFitxerEscuderies(fitxer);

            do
            {
                if (esc[i].NomEsc.Equals(nomEsc))
                    return esc[i];
                i++;
            } while (esc[i] != null);
            return null;
        }


    }
}
