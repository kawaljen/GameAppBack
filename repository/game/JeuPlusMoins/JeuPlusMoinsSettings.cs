using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

public class JeuPlusMoinsSettings :GameSettings
    {

        //private static  MastermindSettings settings;
        public int nbColors;

        public  JeuPlusMoinsSettings()
        {

            SetNbGuesses(10);
            SetNbCases(4);
            SetOffset();
        }

    

    }
