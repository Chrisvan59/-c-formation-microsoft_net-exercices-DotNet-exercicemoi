// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Trouvez le Mystere ---");
Console.WriteLine("");


int nombre = 0;
Random r = new Random();
int count = 0;
int nombreMystere = r.Next(1, 51);
while (nombre != nombreMystere) 
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Veuillez entrer un nombre entre 1 et 51:  ");
    nombre = Convert.ToInt32(Console.ReadLine());
    if (nombre > nombreMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" le nombre est plus petit");
        count++;
    }
    else if (nombre < nombreMystere) 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre est plus grand");
        count++;
    }
}
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Vous avez trouvé en " +count + " coups.");
Console.WriteLine("");
Console.WriteLine("Appuyer sur Entrer pour fermer le programme...");


