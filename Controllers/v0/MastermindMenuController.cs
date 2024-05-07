using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interface;
using api.Models;
using api.repository;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/v0/mastermind/menu")]
    public class MastermindMenuController : ControllerBase
    {

        private readonly IPlay _inst;
        private readonly GameMainMenu _resp;
        public MastermindMenuController(IPlay inst)
        {
            _inst = inst;

        }
        [HttpGet]
        public IActionResult GetMenuItems()
        {
           
           GameMainMenu resp = _inst.GetGameMainMenuItems();

           return resp == null ? NotFound() : Ok(resp); 

        }
        [HttpGet("{mode}")]
        public IActionResult StartGame([FromRoute] GameModes Mode)
        {
           
             _inst.StartGame(Mode);
            string resp ="ok";
            return resp == null ? NotFound() : Ok(resp); 

        }
    }
}