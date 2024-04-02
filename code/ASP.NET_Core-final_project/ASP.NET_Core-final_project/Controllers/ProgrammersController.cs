using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using ASPNET_Core_final_project.Data.Models;
using ASPNET_Core_final_project.Data.Models.ViewModels;
using ASPNET_Core_final_project.Data.Services;

namespace ASPNET_Core_final_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammersController : ControllerBase
    {
        private ProgrammersService _programmersService;

        public ProgrammersController(ProgrammersService programmersService)
        {
            _programmersService = programmersService;
        }


        [HttpPost("programmer-add")]
        public IActionResult AddProgrammer([FromBody] ProgrammerVM programmer)
        {
            _programmersService.AddProgrammer(programmer);
            return Ok();
        }

        [HttpPut("programmer-update/{id}")]
        public IActionResult UpdateProgrmmer(uint id, [FromBody] ProgrammerVM programmer)
        {
            _programmersService.UpdateProgrammer(id, programmer);
            return Ok();
        }

        [HttpGet("programmer-get-all")]
        public IActionResult GetAllProgrammers() 
        {
            var programmers = _programmersService.GetAllProgrammers();
            return Ok(programmers);
        }

        [HttpDelete("programmer-delete/{id}")]
        public IActionResult DeleteProgrammer(uint id) 
        {
            _programmersService.RemoveProgrammer(id);
            return Ok();
        }
    }
}
