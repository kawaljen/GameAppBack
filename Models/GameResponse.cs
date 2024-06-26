using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class GameResponse
    {
        public bool win{get; set;}
        public bool lost{get; set;}
        public string computerAnswer {get; set;} = string.Empty;
        public string userInput {get; set;} = string.Empty;
        public string message {get; set;} = string.Empty;
        public bool isValid {get; set;}
        public string devInfo {get; set;} = string.Empty;
        public string errorMessage {get; set;} = string.Empty;

        public GameResponse()
        {
            win = false;
            lost = false;
            isValid = false;
        }

        internal void SetIsValid(bool isValid)
        {
            this.isValid = isValid;
        }

        internal void SetUserInput(string input)
        {
            this.userInput = input;
        }

        internal void SetComputerAnswer(string computerAnswer)
        {
            this.computerAnswer = computerAnswer;
        }

        internal void SetMessage(string message)
        {
            this.message = message;
        }

        internal void SetWin(bool win)
        {
            this.win = win;
        }

        internal void SetLost(bool lost)
        {
            this.lost = lost;
        }

        internal void SetDevInfo(string devInfo)
        {
            this.devInfo = devInfo;
        }

        internal void SetErrorMessage(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }


        public string GetMessage()
        {
            return message + errorMessage;
        }
        public string GetErrorMessage()
        {
            return errorMessage;
        }

        public string GetDevInfo()
        {
            return devInfo;
        }
        public bool GetIsValid()
        {
            return isValid;
        }

    }
}