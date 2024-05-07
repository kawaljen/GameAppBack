using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.repository;

namespace GamesApp. JeuPlusMoins
{
    public class JeuPlusMoinsMenu : GameMenu
    {
        private static  JeuPlusMoinsMenu JeuPlusMoinsEntryInstance;


        private JeuPlusMoinsMenu()
        {
            name = " JeuPlusMoins";
            hasSettings = true;
            hasModes = true;
            if (gameInst !=null) //TODO gameCoreDuel.Any() || 
            {
                gameStarted = true;
            }
            gameInst = new ChallengerMode(); //TODO
        }

        public static GameMenu GetInstance()
        {
            if (JeuPlusMoinsEntryInstance == null)
            {
                JeuPlusMoinsEntryInstance = new JeuPlusMoinsMenu();
            }
            //gameCore = new ChallengerMode();
            return JeuPlusMoinsEntryInstance;
        }

        public override GameCore StartDefenseMode(){
            return new DefenseMode();
        }
        public override GameCore StartChallengerMode(){
            return new ChallengerMode();
        }

        public override GameSettings GetSettings(){
          return new JeuPlusMoinsSettings();
        }

        protected override GameCore ResumeGame()
        {
            throw new NotImplementedException();
        }

        public override GameCore EndGame()
        {
            throw new NotImplementedException();
        }

        public override void ChangeSettings(GameSettings item)
        {
            throw new NotImplementedException();
        }
        public override api.Models.GameMainMenu GetGameMainMenuItems()
        {
            api.Models.GameMainMenu resp = new api.Models.GameMainMenu();
            resp.gameStarted= gameStarted;
            resp.hasModes = hasModes;
            resp.name = name;
            resp.hasSettings = hasSettings;

            return resp;
        }

    }
}