using System.Runtime.InteropServices;
namespace GamesApp.Mastermind
{
public class  MastermindSettings : GameSettings
    {
        //private static  MastermindSettings settings;
        public int nbColors;

        public  MastermindSettings()
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
}