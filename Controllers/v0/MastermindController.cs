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
    [Route("api/v0/mastermind/play")]
    public class MastermindController : ControllerBase
    {

        private readonly IPlay _inst;
        public MastermindController(IPlay inst)
        {
            _inst = inst;

        }
        [HttpGet("{guess}")]
        public IActionResult Play([FromRoute] string guess)
        {
             //_inst.StartGame(GameModes.CHALLENGERMODE);
            GameResponse resp = _inst.PlayATurn(guess);

            return resp == null ? NotFound() : Ok(resp); 

        }


    }
}