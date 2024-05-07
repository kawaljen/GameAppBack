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
         GameMenu _gameMenu;
         GameCore _inst;
        public Play()
        {
            _gameName = "mastermind";
            //_gameCh = GamesApp.Mastermind.MastermindMenu.GetInstance();

            if (_gameName == "jeuplusmoins"){
                 _gameMenu = GamesApp.JeuPlusMoins.JeuPlusMoinsMenu.GetInstance();
            }
            else{
                 _gameMenu = GamesApp.Mastermind.MastermindMenu.GetInstance();
            }
            _inst=  _gameMenu.StartChallengerMode();          
        }

        public GameMainMenu GetGameMainMenuItems()
        {
            GameMainMenu resp =   _gameMenu.GetGameMainMenuItems();

            return resp;
        }
        public void StartGame(GameModes Mode)
        {
            if(Mode == GameModes.DEFENSEMODE){
              _gameMenu.StartDefenseMode();
            }
            else{
               _gameMenu.StartChallengerMode();
            }
        }

        GameResponse IPlay.PlayATurn(string guess)
        {
            return  _gameMenu.gameInst.Play(guess);
        }

        public GameSettings GetSettingsItems()
        {
            return _gameMenu.gameInst._settings;
        }
        public GameSettings ChangeSettingsItem(GameSettings gameSettings)
        {
            _gameMenu.gameInst._settings.SetNbGuesses(gameSettings.nbGuesses);
            _gameMenu.gameInst._settings.SetNbCases(gameSettings.nbCases);

            //
            return _gameMenu.GetSettings();
        }

    }
}