using System;
using api.Models;
namespace GamesApp.Mastermind
{

    public class ChallengerMode : MastermindCore
    {

        public ChallengerMode()
        {
           // GenerateSecretCombinaison();
            
        }
        // public override GameResponse Init()
        // {
        //     GenerateSecretCombinaison();

        //     GameResponse toSend = new GameResponse();
        //     toSend.SetIsValid (true);
        //     toSend.SetMessage ("Let's begin, Try to guess ! ");
        //     return toSend;
        // }

        public override GameResponse PlayC(string guess)
        {
           _guessesCompt++;
            GameResponse toSend = new GameResponse();
            if(_secretCombinaison == null){
                GenerateSecretCombinaison();
            }
            
            if (guess.Length == _secretCombinaison.Length && guess != null)
            {
                MastermindResult response = CheckGuess(guess);
                bool isWon = IsWon(response.matches.ToString());
                bool isLost = IsLost();

                toSend.SetIsValid (true);
                toSend.SetUserInput( guess);
                toSend.SetComputerAnswer(response.matches + " Matches and " + response.misplaced + " misplaced");
                toSend.SetMessage("Proposition " + guess + " - > " + response.matches + " Matches and " + response.misplaced + " misplaced");
                toSend.SetWin(isWon);
                toSend.SetLost( isLost);
                toSend.SetDevInfo($"(Secret Combination: {_secretCombinaison})");

                if (isWon || isLost)
                {
                    //MastermindMenu.EndGame();
                }
            }
            else
            {
                toSend.SetErrorMessage($"The combination you sent was not the right size, we need " + _settings.GetNbCases() + " digits.");
            }
            return toSend;
        }


        public MastermindResult CheckGuess(string guess)
        {
            MastermindResult mastermindResult = new MastermindResult();
            int matches = 0;
            int misplaced = 0;
            if (!_secretCombinaison.Contains(guess))
            {
                for (int i = 0; i < guess.Length; i++)
                {
                    if (_secretCombinaison.Contains(guess[i]))
                    {
                        if (_secretCombinaison.IndexOf(guess[i]) == i) //TODO deals with several time the same digit
                        {
                            matches++;
                        }
                        else
                        {
                            misplaced++;
                        }
                    }
                }
            }
            else
            {
                matches = _settings.GetNbCases();
            }
            mastermindResult.matches = matches;
            mastermindResult.misplaced = misplaced;

            return mastermindResult;
        }
        protected void GenerateSecretCombinaison()
        {
            Random rand = new Random();
            _secretCombinaison = rand.Next(_settings.GetMinCombinaison(), _settings.GetMaxCombinaison() + 1).ToString();
        }
        
    }
}