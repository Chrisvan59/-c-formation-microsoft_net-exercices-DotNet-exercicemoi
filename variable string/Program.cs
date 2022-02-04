// See https://aka.ms/new-console-template for more information
Console.Write("Veuillez saisir votre nom :");
string nom = Console.ReadLine();
Console.Write("Veuillez saisir votre prénom");
string nomComplet = $"Bonjour {nom}";
string prenom = Console.ReadLine();
Console.Write("Veuillez saisir votre age: ");
int age = Convert.ToInt32(Console.ReadLine());


nomComplet = $"{nomComplet} {prenom} {age} ";
Console.WriteLine(nomComplet);

