
using System.ComponentModel;
using api.Models;
using GamesApp.Mastermind;

public abstract class GameCore {

        // protected JeuPlusMoinsSettings settings; //TODO jeuplus moins
         protected GameSettings _settings;

        protected int _guessesCompt = 0;
        public string _secretCombinaison ;
        //protected static GameCore _GameInst;


        public abstract GameResponse Play(string guess);

        protected bool IsWon(string input)
        {
            if (_secretCombinaison.Contains(input))
            {
                return true;
            }
            return false;
        }

        protected bool IsLost()
        {
            int nbguesses =10;
            // if(settings != null )
            // {
            //     nbguesses = settings.nbGuesses;
            // }
            // else {
            //     nbguesses = settingsM.nbGuesses; //TODO
            // }
            if (_guessesCompt >= nbguesses)
            {
                return true;
            }
            return false;
        }
        public GameResponse AfficherDev()
        {
            GameResponse toSend = new GameResponse();
            toSend.SetDevInfo($"(Secret Combination: {_secretCombinaison})"); //TODO ad it to the playresponse
            return toSend;
        }


}
    



