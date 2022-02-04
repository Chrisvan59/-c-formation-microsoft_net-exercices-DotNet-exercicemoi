// See https://aka.ms/new-console-template for more information
Console.Write("Entrez le prix HT de l'objet (en Euros) :");
decimal PrixHT = Convert.ToDecimal(Console.ReadLine());
Console.Write("Entrez le taux de TVA (en %)");
decimal TauxTVA = Convert.ToDecimal(Console.ReadLine());
decimal TVA = PrixHT * TauxTVA / 100;
decimal PrixTTc = PrixHT + TVA;
Console.Write($"Le montant de la tva est de {TVA} Euros  ");  
Console.Write($"Le prix TTC de l'objet est de {PrixHT} Euros");

