using System;
using GamesApp.JeuPlusMoins;
using GamesApp.Mastermind;
using api.Interface;
using api.Models;

public class Gameapp: IGameapp 
    {
        // // private bool isModeDev;

    private List<MainMenuItem> mainMenuItems = new List<MainMenuItem>();

    //GameMenu gameCh;

  

    List<MainMenuItem> IGameapp.GetAll()
    {
        mainMenuItems.Add(new MainMenuItem() { Id = 1, Name="Mastermind"});
        mainMenuItems.Add( new MainMenuItem() { Id = 2, Name="jeu plus moins"});

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
    