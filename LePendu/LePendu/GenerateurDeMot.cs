using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePendu
{
    public class GenerateurDeMot
    {
        private string[] mots = { "goolge", "microsoft", "fecebook", "sopra", "capg" };
        private Random random = new Random();
        public string generer()
        { int radomIndex = random.Next(0, mots.Length);
          return mots[radomIndex];  
        }
    }
}
