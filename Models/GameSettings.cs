using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class GameSettings
    {
        public int nbGuesses{get;set;}
        public int nbCases{get;set;}
        public int nbColors {get;set;}
        protected int maxCombinaison{get;set;}
        protected int minCombinaison{get;set;}

        protected int nbCasesmin{get;set;}
        protected int nbCasesmax{get;set;}
        protected int nbGuessesmax{get;set;}
        protected int nbGuessesmin{get;set;}

        public GameSettings()
        {
            nbCasesmin = 4;
            nbCasesmax = 10;
            nbGuessesmin = 10;
            nbGuessesmax = 50;
        }
            public int GetNbGuesses (){
                return nbGuesses;
            }

            public int GetNbCases (){
                return nbCases;
            }

            public int GetNbColors (){
                return nbColors;
            }
            public int GetMaxCombinaison (){
                return maxCombinaison;
            }
            public int GetMinCombinaison (){
                return minCombinaison;
            }
            public void SetNbCases(int nbCases)
            {
                if (nbCases > nbCasesmin && nbCases <= nbCasesmax)
                {
                    this.nbCases = nbCases;
                    SetOffset();
                }
                else
                {
                    // Exception handling // TODO exeption
                }
            }
            public void SetNbColors(int nbColors)
            {
                if (nbCases > 4  && nbColors <= 10)
                {
                    this.nbColors = nbColors;

                }
                else
                {
                    // Exception handling // TODO exeption
                }
            }

            public void SetNbGuesses(int nbGuesses)
            {
                if (nbGuesses > nbGuessesmin && nbGuesses <= nbGuessesmax)
                {
                    this.nbGuesses = nbGuesses;
                }
                else
                { 
                    // Exception handling // TODO exeption
                }
            }
            protected void SetOffset(){
                int max = 1;
                for (int i = 0; i < nbCases; i++)
                {
                    max = max * 10;
                }
                minCombinaison = max / 10;
                maxCombinaison = max -1;
            }
    }
}