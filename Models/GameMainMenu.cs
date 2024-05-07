using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class GameMainMenu
    {
        public string name {get; set;} = string.Empty;
        public bool hasSettings {get; set;}
        public bool hasModes{get; set;}
        public bool gameStarted {get; set;}
       //public enum Modes { CHALLENGERMODE, DEFENSEMODE, DUELMODE };  
    }
}