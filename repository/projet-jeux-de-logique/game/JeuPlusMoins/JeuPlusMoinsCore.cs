
using api.Models;
    public abstract class JeuPlusMoinsCore : GameCore
    {
         protected JeuPlusMoinsSettings settings;
        // public int guessesCompt = 0;
        // protected string secretCombinaison;

        protected JeuPlusMoinsCore()
        {
            guessesCompt = 0;
            settings = new JeuPlusMoinsSettings();
            //Init();
        }


        protected string Afficher(string test)
        {
            return test;
        }

        public override GameResponse Play(string guess){
            return PlayC(guess);

        }
        public abstract GameResponse PlayC(string guess);

        public abstract GameResponse Init();

    }
