using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.repository
{
    public abstract class GameMenu
    {
        public string name = "";
        public bool hasSettings = false;
        public bool hasModes = false;
        public bool gameStarted = false;
        public static GameCore[] gameCoreDuel;
        public GameCore gameInst;
        private enum Modes { CHALLENGERMODE, DEFENSEMODE, DUELMODE };       
        public abstract GameCore StartDefenseMode();
        public abstract GameCore StartChallengerMode();
        //protected abstract GameCore[] StartDuelMode();

        protected abstract GameCore ResumeGame();
        public abstract GameSettings GetSettings();

        public abstract void ChangeSettings(GameSettings item);
        public abstract GameMainMenu GetGameMainMenuItems();

        public abstract GameCore EndGame();
    }
}