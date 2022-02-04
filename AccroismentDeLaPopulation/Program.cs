// See https://aka.ms/new-console-template for more information
Console.WriteLine("----Accroisment de la population-----");
int annee = 2015;
double habitants = 96809;


    Console.WriteLine("Il faudra 25 ans, nous serons en "+annee  );
annee++;

while (annee >= annee + 25)

    Console.WriteLine("il y aura " + habitants +  "en " + annee);
while (habitants <= 120000)
{
    habitants += habitants * (0.89 / 100);
    habitants++;


}
Console.WriteLine("Appuyer sur Entrer pour fermer le programme...");
