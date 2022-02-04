using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apprendreLesClasses.classes
{


    public class Chaises
    {
        private int NbPieds;
        private string Couleur;
        private string Materiaux;
        private static int compteur = 0;
        public int nbPieds

        {
            get => NbPieds; set
            {
                if (value > 2)
                    nbPieds = value;
                else
                    Console.WriteLine("Erreur de nombre de pieds");
            }

        }





        public string Couleur1 { get => Couleur; set => Couleur = value; }
        public string Materiaux1 { get => Materiaux; set => Materiaux = value; }
        public static int Compteur { get => compteur; }

        public Chaises()
        {
            compteur++;
        }

        public Chaises(int nbPieds, string couleur, string materiaux) : this()
        {
            NbPieds = nbPieds;
            Couleur = couleur;
            Materiaux = materiaux;
        }

        
    }
}

