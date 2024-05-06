using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Interface
{
    public interface IGameapp
    {
        List<MainMenuItem> GetAll();

        //GameMenu ChooseGame(string gameName);
    }
}