using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interface;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.v0
{
    [ApiController]
    [Route("api/v0/mastermind/settings")]
    public class MastermindSettingController : ControllerBase
    {
        private readonly IPlay _inst;
        public MastermindSettingController(IPlay inst)
        {
            _inst = inst;

        }
        [HttpGet]
        public IActionResult GetSettingsItems()
        {
           
            GameSettings resp = _inst.GetSettingsItems( );

            return resp == null ? NotFound() : Ok(resp); 

        }
        [HttpGet("{items}")]
        public IActionResult ChangeSettingsItem([FromRoute] GameSettings gameSettings)
        {
           
            GameSettings resp =_inst.ChangeSettingsItem(gameSettings);
            return resp == null ? NotFound() : Ok(resp); 

        }  
    }
}