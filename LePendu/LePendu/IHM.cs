using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePendu
{
    public class IHM
    {
        private LePendu pendu;
        private GenerateurDeMot generateurDeMot;

        public IHM()
        {
            generateurDeMot = new GenerateurDeMot();


        }

        public void Start()
        {

            pendu = new LePendu();
            pendu.GenereMasque(generateurDeMot);
            do
            {
                Affichage();
                Console.WriteLine("veuillez saisir une lettre: ");
                char c = Convert.ToChar(Console.ReadLine);
                if (pendu.TestChar(c))
                {
                    Console.WriteLine("Bravo vous avez trouvé un caractère dans le mot");
                }
                else
                {
                    Console.WriteLine($"Le caractère n'existe pas, il vous reste :");
                }
            } while (pendu.NbEssai > 0 && !pendu.TestWin());

            if (pendu.NbEssai > 0)
            {
                Console.WriteLine("Bravo vous avez gagné !!!!");
            }
            else
            {
                Console.WriteLine("Désolé, vous avez perdu :(");
            }
        }
            private void Affichage()
        {

            Console.WriteLine("------ Le jeu du pendu -------");
                Console.WriteLine($"Le mot est : {pendu.Masque }");


        }
            }

                
            
        }

    


