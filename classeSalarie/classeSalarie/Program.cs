using System;

namespace classeSalarie;
    internal class Program
    {
        static void Main(string[] args)
        {
           Salarie s = new Salarie();
         s.AfficherSalaire();
        string choix;
        do
        {

            Console.Write("Ajouter un salarié : (o/n)");
            choix = Console.ReadLine();
            if (choix == "o")
            {

                Salarie salarie = new Salarie();
                Console.Write("Le matricule :");
                salarie.Matricule = Console.ReadLine();
                Console.Write("Le service : ");
                salarie.Service = Console.ReadLine();
                Console.Write("La catégorie: ");
                salarie.Categorie = Console.ReadLine();
                Console.Write("Le nom complet :");
                salarie.Nom = Console.ReadLine();
                Console.Write("Le salaire : ");
                salarie.Salaire =  Convert.ToDecimal(Console.ReadLine());
                salarie.AfficherSalaire();
            }
        } while (choix != "n");

        Console.WriteLine($"Le total des salaires est de :{Salarie.TotalSalaires} euros ");
        Salarie.MettreAjourLeCompteur();
        Console.WriteLine($"Le nombre de salarié est de: {Salarie.Compteur}");
        Salarie.MettreAjourLeCompteur(100);
        Console.WriteLine($"Le nombre de salariés est de : {Salarie.Compteur}");

        

    }
}