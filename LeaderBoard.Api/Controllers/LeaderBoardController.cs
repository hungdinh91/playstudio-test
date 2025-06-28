using Microsoft.AspNetCore.Mvc;

namespace LeaderBoard.Controllers
{
    [ApiController]
    [Route("leaderboard")]
    public class LeaderBoardController : ControllerBase
    {
        private readonly ILogger<LeaderBoardController> _logger;

        public LeaderBoardController(ILogger<LeaderBoardController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("OK");
        }
    }
}
