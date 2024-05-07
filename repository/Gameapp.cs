using System;
using GamesApp.JeuPlusMoins;
using GamesApp.Mastermind;
using api.Interface;
using api.Models;

public class Gameapp: IGameapp 
    {
        // // private bool isModeDev;

    private List<AppMainMenuItem> mainMenuItems = new List<AppMainMenuItem>();

    //GameMenu gameCh;

  

    List<AppMainMenuItem> IGameapp.GetAll()
    {
        mainMenuItems.Add(new AppMainMenuItem() { Id = 1, Name="Mastermind"});
        mainMenuItems.Add( new AppMainMenuItem() { Id = 2, Name="jeu plus moins"});

        return mainMenuItems;
    }


//    GameMenu IGameapp.ChooseGame(string gameName)
//     {
//         gameCh = GamesApp.Mastermind.MastermindMenu.GetInstance();

//         if (gameName == "jeuplusmoins"){
//             gameCh = GamesApp.JeuPlusMoins.JeuPlusMoinsMenu.GetInstance();
//         }
//         return  gameCh;  
//     }
}
