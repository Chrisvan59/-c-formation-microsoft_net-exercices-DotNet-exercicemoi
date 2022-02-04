 using System;
using apprendreLesClasses.classes;

namespace apprendreLesClases // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choix;
            do
            {
                Console.WriteLine("Un nouvelle chaise (o/n) ?");
                choix = Console.ReadLine();
                if (choix == "o")
                {
                    Console.WriteLine("Le nombre de pieds de la chaise : ");
                    int NbPied = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Le type de matériaux de la chaise: ");
                    string materiaux = Console.ReadLine();
                    Console.WriteLine("la couleur de la chaise: ");
                    string couleur = Console.ReadLine(); ;
                    Chaises chaises = new Chaises(NbPied, couleur, materiaux);
                    Console.WriteLine("------------Affichage d'un nouvelle objet------------");
                    Console.WriteLine($"je suis une chaise avec {NbPied} pied(s)  en {materiaux} et de couleur {couleur}");
                    Console.WriteLine("------------------------------------------------------------------------");

                }
            } while (choix != "n");



        }      

    }
}

