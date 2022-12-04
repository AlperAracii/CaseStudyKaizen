using CaseStudyKaizen.Services.Question1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CaseStudyKaizen.Controllers
{
    [Route("api/question1")]
    public class Question1Controller : ControllerBase
    {
        private readonly IQuestion1Service _campaignCodeService;
        public Question1Controller(IQuestion1Service campaignCodeService)
        {
            _campaignCodeService = campaignCodeService;
        }

        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [HttpGet("{howManyCode}")]
        public IActionResult CreateCampaignCode([FromRoute] int howManyCode)
        {
            var response =  _campaignCodeService.CreateCampaignCode(howManyCode);
            return Ok(response);
        }

        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [HttpGet("check/{code}")]
        public IActionResult CheckCode([FromRoute] string code)
        {
            var response =  _campaignCodeService.CheckCode(code);
            return Ok(response);
        }
    }
}
