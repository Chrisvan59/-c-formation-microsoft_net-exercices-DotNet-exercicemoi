// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Calcul du périmetre et de l'air d'un carré ---");
Console.WriteLine("Merci de saisir la longueur du coté ;");
Console.ReadLine();
double cote = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Le permimetre du carré est:{ cote * 4} ");

Console.WriteLine($"L'aire du carré est :{ cote * cote}");

Console.WriteLine("appuyer sur une touche pour fermer le programme");
