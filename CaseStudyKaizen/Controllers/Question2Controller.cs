using CaseStudyKaizen.Models;
using CaseStudyKaizen.Services.Question2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudyKaizen.Controllers
{
    [Route("api/question2")]
    public class Question2Controller : ControllerBase
    {
        public readonly IQuestion2Service _question2Service;

        public Question2Controller(IQuestion2Service question2Service)
        {
            _question2Service = question2Service;
        }

        [ProducesResponseType(typeof(ContentWithLanguageResponseModel), StatusCodes.Status200OK)]
        [HttpGet("{languageCode}")]
        public IActionResult GetContentWithLanguage([FromRoute] string languageCode)
        {
            var response = _question2Service.GetContentWithLanguage(languageCode);
            return Ok(response);
        }

    }
}
