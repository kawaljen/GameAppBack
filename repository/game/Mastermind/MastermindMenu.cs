using api.Models;
using api.repository;

namespace GamesApp.Mastermind
{
    public class MastermindMenu : GameMenu
    {
        private static MastermindMenu _inst;
        private MastermindMenu()
        {
            name = "Mastermind";
            hasSettings = true;
            hasModes = true;
            if (gameInst !=null) //TODO gameCoreDuel.Any() || 
            {
                gameStarted = true;
            }
            gameInst = new ChallengerMode(); //TODO
        }
        public static MastermindMenu GetInstance()
        {
            if ( _inst == null)
            {
                 _inst = new MastermindMenu();
            }
            return _inst;
        }
        public override GameCore StartDefenseMode(){
            gameInst = new ChallengerMode();
            return gameInst;
        }
        public override GameCore StartChallengerMode(){
            gameInst = new ChallengerMode();
            return gameInst;
        }

        public override GameSettings GetSettings(){

          return gameInst._settings;
        }

        protected override GameCore ResumeGame()
        {
           return gameInst;
        }
        public override void ChangeSettings(GameSettings item){
            //TODO
        }


        public override GameCore EndGame()
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