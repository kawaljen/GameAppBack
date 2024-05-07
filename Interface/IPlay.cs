using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.repository;

namespace api.Interface
{
    public interface IPlay
    {
        GameResponse PlayATurn(string guess);
        void StartGame(GameModes Mode);

        GameMainMenu GetGameMainMenuItems();

         GameSettings GetSettingsItems();

         GameSettings ChangeSettingsItem(GameSettings item);
        
    }
}