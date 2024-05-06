using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interface;
using api.Models;
using Microsoft.AspNetCore.Mvc;


namespace api.Controllers
{
    [ApiController]
    [Route("api/v0/mainmenu")]
    public class MainMenuController : ControllerBase
    {
         private IGameapp _gamesapp;
        private List<MainMenuItem> _mainMenuItems;
        public MainMenuController(IGameapp gamesapp)
        {
            _gamesapp = gamesapp;
            _mainMenuItems = _gamesapp.GetAll();
        }  


        [HttpGet]
        public ActionResult GetAll(){

            return _mainMenuItems == null ? NotFound() : Ok(_mainMenuItems); 

        }
    }
}