using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranPremiVictorCasa.Clases
{
    [Serializable]
   public class pilot
    {
        //variables privades
        private String nom;
        private String nacionalitat;
        private int dorsal;
        private Escuderia escu;

        //constructores
        public pilot()
        {
        }

        public pilot(string nom, string nacionalitat, int dorsal, Escuderia escu)
        {
            this.nom = nom;
            this.nacionalitat = nacionalitat;
            this.dorsal = dorsal;
            this.escu = escu;
        }

        //GETTERS & SETTERS
        public string Nom { get => nom;  }
        public string Nacionalitat { get => nacionalitat; }
        public int Dorsal { get => dorsal;  }
        public Escuderia Escu { get => escu;  }



        //RESTA METODES
        /// <summary>
        /// Retorna el mode d'escriptura del fitxer
        /// Append (afegir) o Create (Reescriure)
        /// </summary>
        /// <param name="afegir">afegeix(true) o reescriu(false)</param>
        /// <returns>Objecte <see cref="FileMode"/></returns>
        private FileMode modeApertura(Boolean afegir)
        {

            if (afegir)
                return FileMode.Append;
            else
                return FileMode.Create;
        }

        /// <summary>
        /// Afegeix un objecte llibre a l'arxiu per defecte
        /// </summary>
        /// <param name="lli">Objecte Llibre</param>
        /// <param name="arxiu">Ruta de l'arxiu de llibres</param>
        public void afegeixPilotFitxer(Boolean afegir = true,String arxiu = "fitxer/pilot.dat")
        {

            FileMode f = modeApertura(afegir);

            Stream str = File.Open(arxiu, f);


            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(str, this);
            str.Close();
        }

        /// <summary>
        /// Llegeix un pilot del fitxer i retorna un vector d'objectes pilot
        /// </summary>
        /// <param name="fitxer">Ruta del fitxer de pilot</param>
        /// <returns>Retorna vector d'objectes pilot</returns>
        public pilot[] llegeixPilotFitxer(String fitxer = "fitxer/pilot.dat")
        {

            Stream str = File.Open(fitxer, FileMode.Open);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            int q = 0;
            pilot[] pi = new pilot[100];

            do
            {
                try
                {
                    pi[q] = (pilot)formatter.Deserialize(str);
                }
                catch
                {
                    //MessageBox.Show("Error al llegir el fitxer d'Objectes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                q++;
            } while (pi[q - 1] != null);

            str.Close();
            return pi;
        }


        public pilot cercarPilot(String nomPil, String fitxer = "fitxer/pilot.dat")
        {
            // retorna un objecte autor si el troba
            // en cas que no trobe res torna un null

            pilot[] pil = new pilot[100];

            // leemos todas las escuderias
            pil = llegeixPilotFitxer();

            int i = 0;
            //buscamos la escuderia
            do
            {
                if (pil[i].Nom.Equals(nomPil))
                    return pil[i];
                i++;
            } while (pil[i] != null);
            return null;



        }

        public void eliminaPilot(String nom_pil)
        {
            pilot[] pil = new pilot[100];

            // llegim totes les escuderies
            pil = llegeixPilotFitxer();

            int i = 0;
            // per comprovar la primera escriptura
            Boolean primer = true;

            // busquem la escuderia
            do
            {
                // quant trobem la que volem borrar no la reescrivim
                if (!pil[i].Nom.Equals(nom_pil))
                {
                    if (primer)
                    {
                        // generem fitxer nou
                        pil[i].afegeixPilotFitxer(false);
                        primer = false;
                    }
                    else
                    {
                        // afegim al fitxer
                        pil[i].afegeixPilotFitxer(true);
                    }
                }
                i++;
            } while (pil[i] != null);
        }



        //CONTAREMOS elS PILOT DE DENTRO DEL FICHERO
        public int contaPilots()
        {
            int total = 0;

            pilot[] esc = new pilot[100];

            // llegim totes les escuderies
            esc = llegeixPilotFitxer();

            // busquem la escuderia
            while (esc[total] != null)
            {
                total++;
            }
            return total;
        }




    }
}
