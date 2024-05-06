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
         GameEntry _gameCh;
         GameCore _inst;
        public Play()
        {
            _gameName = "mastermind";
            _gameCh = GamesApp.Mastermind.MastermindEntry.GetInstance();

            // if (_gameName == "jeuplusmoins"){
            //     _gameCh = GamesApp.JeuPlusMoins.JeuPlusMoinsEntry.GetInstance();
            // }
           // _inst=  _gameCh.StartNewGame();          
        }

        GameResponse IPlay.PlayATurn(string guess, string gameName)
        {
            return _gameCh.gameCore.Play(guess);
        }
    }
}