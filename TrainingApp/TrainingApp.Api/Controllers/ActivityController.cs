using Microsoft.AspNetCore.Mvc;
using TrainingApp.Business.Contracts;
using TrainingApp.Business.Models;

namespace TrainingApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _activityService.GetActivitiesAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> InsertActivityAsync([FromBody] ActivityBaseModel model)
        {
            await _activityService.InsertActivityAsync(model);
            return CreatedAtAction(null, null);
        }
    }
}
