using Microsoft.AspNetCore.Mvc;
using TrainingApp.Business.Contracts;
using TrainingApp.Business.Models;

namespace TrainingApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] UserModel model)
        {
            await _userService.InsertUser(model);
            return Ok();
        }
    }
}
