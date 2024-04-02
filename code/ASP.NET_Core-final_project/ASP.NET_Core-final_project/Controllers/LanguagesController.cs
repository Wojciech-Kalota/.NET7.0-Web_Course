using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASPNET_Core_final_project.Data.Models;
using ASPNET_Core_final_project.Data.Models.ViewModels;
using ASPNET_Core_final_project.Data.Services;

namespace ASPNET_Core_final_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        public LanguagesService _languagesService;

        public LanguagesController(LanguagesService languagesService)
        {
            _languagesService = languagesService;
        }


        [HttpPost("add-language")]
        public IActionResult AddLanguage([FromBody]LanguageVM language)
        {
            _languagesService.AddLanguage(language);
            return Ok();
        }

        [HttpPut("update-language/{id}")]
        public IActionResult UpdateLanguage(uint id, [FromBody]LanguageVM language) 
        { 
            _languagesService.UpdateLanguage(id, language);
            return Ok();
        }

        [HttpGet("get-langueges")]
        public IActionResult GetLanguages()
        {
            var languages = _languagesService.GetLanguages();
            return Ok(languages);
        }

        [HttpDelete("language-remove/{id}")]
        public IActionResult RemoveLanguage(uint id)
        {
            _languagesService.RemoveLanguage(id);
            return Ok();
        }
    }
}
