 public abstract class GameEntry
    {
        public string name = "";
        public bool hasSettings = false;
        public bool hasModes = false;
        public bool gameStarted = false;
        public static GameCore[] gameCoreDuel;
        public GameCore gameCore;
        private enum Modes { CHALLENGERMODE, DEFENSEMODE, DUELMODE };

        protected abstract GameCore StartDefenseMode();
        protected abstract GameCore StartChallengerMode();
        public abstract GameSettings GetSettings();


        public GameCore StartNewGame(object mode)
        {
            gameCoreDuel = new GameCore[2];
            if (mode.Equals(Modes.DEFENSEMODE))
            {
                gameCore =  StartDefenseMode();
            }
            else
            {
                gameCore = StartChallengerMode();
            }
            return gameCore;
        }
        public  GameCore StartNewGame()
        {
            gameCoreDuel = new GameCore[2];
            gameCore = StartChallengerMode();
            
            return gameCore;
        }        
        
        public  GameCore[] StartNewDuelGame()
        {
            gameCoreDuel = new GameCore[2];
            gameCoreDuel[0] = StartChallengerMode();
            gameCoreDuel[1] =  StartDefenseMode();

            
        
            return gameCoreDuel;
        }

        public GameCore ResumeGame()
        {
            // Implement resume logic if needed //TODO 
            return gameCore;
        }

        public GameCore[] ResumeDuelGame()
        {
            // Implement resume logic if needed //TODO 
            return gameCoreDuel;
        }
        public static void EndGame()
        {
            //gameCore = null;
            gameCoreDuel= new GameCore[2]; 
        }

}
