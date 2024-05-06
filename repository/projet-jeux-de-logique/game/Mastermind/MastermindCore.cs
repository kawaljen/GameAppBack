using api.Models;
namespace GamesApp.Mastermind
{


    public abstract class MastermindCore : GameCore
    {
        protected MastermindSettings settings;


        public MastermindCore()
        {
            guessesCompt = 0;
            settings = new MastermindSettings();
            //Init();
        }


        public override GameResponse Play(string guess){
            return PlayC(guess);

        }
        public abstract GameResponse PlayC(string guess);

        public abstract GameResponse Init();


    }
}
