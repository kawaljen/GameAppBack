using api.Models;
namespace GamesApp.Mastermind
{


    public abstract class MastermindCore : GameCore
    {
        protected MastermindSettings _settings;

        protected string GameStarted;

        public MastermindCore()
        {
            _guessesCompt = 0;
            _settings = new MastermindSettings();
        }


        public override GameResponse Play(string guess){
            return PlayC(guess);

        }
        public abstract GameResponse PlayC(string guess);
    }
}
