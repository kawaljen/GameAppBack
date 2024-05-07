using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interface;
using api.Models;
namespace api.repository
{
    public class Play :IPlay
    {
        //private GameLogic _inst;
        string _gameName ;
         GameMenu _gameCh;
         GameCore _inst;
        public Play()
        {
            _gameName = "mastermind";
            //_gameCh = GamesApp.Mastermind.MastermindMenu.GetInstance();

            if (_gameName == "jeuplusmoins"){
                _gameCh = GamesApp.JeuPlusMoins.JeuPlusMoinsMenu.GetInstance();
            }
            else{
                _gameCh = GamesApp.Mastermind.MastermindMenu.GetInstance();
            }
            _inst= _gameCh.StartChallengerMode();          
        }

        public GameMainMenu GetGameMainMenuItems()
        {
            GameMainMenu resp =  _gameCh.GetGameMainMenuItems();

            return resp;
        }
        public void StartGame(GameModes Mode)
        {
            if(Mode == GameModes.DEFENSEMODE){
             _gameCh.StartDefenseMode();
            }
            else{
              _gameCh.StartChallengerMode();
            }
        }

        GameResponse IPlay.PlayATurn(string guess)
        {
            return _gameCh.gameInst.Play(guess);
        }

        public GameSettings GetSettingsItems()
        {
            return _gameCh.GetSettings();
        }
        public GameSettings ChangeSettingsItem(GameSettings item)
        {

            //
            return _gameCh.GetSettings();
        }

    }
}