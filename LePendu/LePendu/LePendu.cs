using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePendu
{
    public class LePendu
    {
        private int nbEssai;
        private string masque;
        private string motATrouver;



        public int NbEssai { get => nbEssai; }
        public string Masque { get => masque; }
        public string MotATrouver { get => motATrouver; }

        public LePendu()
        {
            nbEssai = 10;
        }
        public bool TestChar(char c)
        {
            bool result = false;
            string newMasque = "";
            for (int i = 0; i < MotATrouver.Length; i++)
                if (MotATrouver[i] == c)
                {
                    newMasque += c;
                    result = true;

                }
                else
                {
                    newMasque += Masque[i];
                }
            masque = newMasque;
            if (!result)
            {
                nbEssai--;
            }
            return result;
        }

        public bool TestWin()
        {

            return nbEssai > 0 && MotATrouver == Masque;
        
        
        }




            public void GenereMasque(GenerateurDeMot generateur)
        {
            masque = "";
            for (int i=0; i < MotATrouver.Length; i++)
            {
                masque += "*";
            }
        }
    } } 
