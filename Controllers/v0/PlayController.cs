using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    // [ApiController]
    // [Route("api/v0/play")]
    // public class PlayController : ControllerBase
    // {
    //     [HttpGet("{guess}")]
    //     public IActionResult Play([FromRoute] string guess)
    //     {
    //         GamesApplication game = new GamesApplication();
    //         GameMenu mastermind = game.ChooseGames();
    //         GameLogic inst = mastermind.StartNewGame();
    //         GameResponse resp = inst.Play(guess);

    //         return resp == null ? NotFound() : Ok(resp); 

    //     }
    //      [HttpGet]
    //     public IActionResult Play()
    //     {
    //         string respJPM = " ";

    //         return respJPM == null ? NotFound() : Ok(respJPM); 

    //     }
    // }
    
}