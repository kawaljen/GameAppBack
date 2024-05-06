using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesApp. JeuPlusMoins
{
    public class JeuPlusMoinsEntry : GameEntry
    {
        private static  JeuPlusMoinsEntry JeuPlusMoinsEntryInstance;


        private JeuPlusMoinsEntry()
        {
            name = " JeuPlusMoins";
            hasSettings = true;
            hasModes = true;
            if (gameCore !=null) //TODO gameCoreDuel.Any() || 
            {
                gameStarted = true;
            }
            gameCore = new ChallengerMode(); //TODO
        }

        public static GameEntry GetInstance()
        {
            if (JeuPlusMoinsEntryInstance == null)
            {
                JeuPlusMoinsEntryInstance = new JeuPlusMoinsEntry();
            }
            //gameCore = new ChallengerMode();
            return JeuPlusMoinsEntryInstance;
        }

        protected override GameCore StartDefenseMode(){
            return new DefenseMode();
        }
        protected override GameCore StartChallengerMode(){
            return new ChallengerMode();
        }

        public override GameSettings GetSettings(){
          return new JeuPlusMoinsSettings();
        }
    }
}