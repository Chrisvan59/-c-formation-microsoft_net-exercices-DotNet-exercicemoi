// See https://aka.ms/new-console-template for more information
Console.Write("--- Calcul de l'hyporhenuse ---");
Console.Write("Entrez la longueur du premier côté (en cm) ");
double PremierCote = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Entrer la longueur du deuxieme coté (en cm)");
double DeuxiemeCote = Convert.ToDouble(Console.ReadLine());
Console.Write($" La longeur de l'hypothenuse est {PremierCote *2 +   DeuxiemeCote *2}");
