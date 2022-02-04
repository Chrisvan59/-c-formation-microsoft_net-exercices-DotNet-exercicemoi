// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Le nombre est-il divisible par ... ?---");
Console.WriteLine("Entrez un chiffre/nombre entier :");
int entier = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrez le chiffre/nombre diviseur :");
int nombreDiviseur = Convert.ToInt32(Console.ReadLine());
if (entier % nombreDiviseur == 0)

    Console.WriteLine($"Le chiffre/nombre {entier} est divisible pr {nombreDiviseur}");
    else
    Console.WriteLine($"Le chiffre/nombre {entier} n'est pas divisible par {nombreDiviseur}");
