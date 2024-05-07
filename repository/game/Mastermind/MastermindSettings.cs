using System.Runtime.InteropServices;
using api.Models;
namespace GamesApp.Mastermind
{
public class  MastermindSettings : GameSettings
    {

        //public int nbColors;

        public  MastermindSettings()
        {

            SetNbColors(4);
            SetNbGuesses(10);
            SetNbCases(4);
            SetOffset();
        }

    }
}