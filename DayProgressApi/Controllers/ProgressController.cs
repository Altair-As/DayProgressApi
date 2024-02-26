using DayProgressApi.Models;
using DayProgressApi.Services;
using DayProgressApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DayProgressApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProgressController : ControllerBase
    {
        // Logic implementation
        private readonly IProgressService _progressService;

        public ProgressController(IProgressService progressService)
        {
            _progressService = progressService;
        }

        [HttpGet]
        public ActionResult<Progress> GetProgress()
        {
            // TODO: Remove placeholders (it is meant to load values from session)
            var start = new TimeSpan(8, 30, 00);
            var end = new TimeSpan(17, 00, 00);

            return Ok(_progressService.GetProgress(start, end));
        }
    }
}
