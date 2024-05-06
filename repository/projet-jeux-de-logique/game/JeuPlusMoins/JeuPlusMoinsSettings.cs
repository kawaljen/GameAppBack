using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class JeuPlusMoinsSettings :GameSettings
    {

        //private static  MastermindSettings settings;
        public int nbColors;

        public  JeuPlusMoinsSettings()
        {
            nbGuesses = 10;
            nbCases = 4;
            nbCasesmin = 4;
            nbCasesmax = 10;
            nbGuessesmin = 10;
            nbGuessesmax = 50;
            nbColors = 6;
            SetOffset();
        }

    

    }
