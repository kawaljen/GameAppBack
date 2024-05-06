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
    [Route("api/v0/mastermind")]
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
            GameResponse resp = _inst.PlayATurn(guess, "mastermind");

            return resp == null ? NotFound() : Ok(resp); 

        }
     //    [HttpGet]
        // public IActionResult Play()
        // {
        //     string respJPM = " ";

        //     return respJPM == null ? NotFound() : Ok(respJPM); 

        // }
    }
}