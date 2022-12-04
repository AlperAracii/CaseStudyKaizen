using CaseStudyKaizen.Services.Question3;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudyKaizen.Controllers
{
    [Route("api/question3")]
    public class Question3Controller : ControllerBase
    {
        private readonly IQuestion3Service _question3Service;
        public Question3Controller(IQuestion3Service question3Service)
        {
            _question3Service = question3Service;
        }

        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [HttpGet]
        public IActionResult JsonToString()
        {
            var response = _question3Service.JsonToString();
            return Ok(response);
        }
    }
}
