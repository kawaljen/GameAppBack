namespace GamesApp.Mastermind
{
    public class MastermindEntry : GameEntry
    {
        private static MastermindEntry MastermindMenuInstance;


        private MastermindEntry()
        {
            name = "Mastermind";
            hasSettings = true;
            hasModes = true;
            if (gameCore !=null) //TODO gameCoreDuel.Any() || 
            {
                gameStarted = true;
            }
            gameCore = new ChallengerMode(); //TODO
        }

        public static GameEntry GetInstance()
        {
            if (MastermindMenuInstance == null)
            {
                MastermindMenuInstance = new MastermindEntry();
            }
            //gameCore = new ChallengerMode();
            return MastermindMenuInstance;
        }

        protected override GameCore StartDefenseMode(){
            return new DefenseMode();
        }
        protected override GameCore StartChallengerMode(){
            return new ChallengerMode();
        }

        public override GameSettings GetSettings(){
          return new MastermindSettings();
        }
    }
}