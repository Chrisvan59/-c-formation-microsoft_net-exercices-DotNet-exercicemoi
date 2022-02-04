// See https://aka.ms/new-console-template for more information
Console.Write("quelle sera le montant de mes impots ");
Console.Write("");
Console.WriteLine("Entrez le montant net imposable du foyer ");
decimal MontantImposable = Convert.ToDecimal(Console.ReadLine());
Console.Write("Entrez le nombre d'adulte du foyer :");
int adulteFoyer = Convert.ToInt32(Console.ReadLine());
Console.Write("Entrer le nombre d'enfants ");
int enfantFoyer = Convert.ToInt32(Console.ReadLine());
decimal nbPart = adulteFoyer;
if (enfantFoyer <= 2)
    nbPart += (enfantFoyer <= 2) ? 0.5m * enfantFoyer : (enfantFoyer - 1);
decimal vallInterval = MontantImposable / nbPart;
decimal taux = 0;
decimal app = 0;
switch(vallInterval)
{
    case (decimal n) when n < 10225:
        taux = 0;
        app = 0;
        break;
    case (decimal n) when n >= 10225 && n < 2670 :
        taux = 0.11M;
        app = 1124.75M;
        break;
    case (decimal n) when n >= 26070 && n < 74545:
        taux = 0.3M;
        app = 1427M;
        break;
    case (decimal n) when n >= 74545 && n < 160336:
        taux = 0.45M;
        app = 20691.44M;
        break;
    default:
        break;
}
decimal impot = MontantImposable * taux - app * nbPart;
Console.WriteLine($"Le montant de vos impôts est de {Math.Round(impot)}");







  