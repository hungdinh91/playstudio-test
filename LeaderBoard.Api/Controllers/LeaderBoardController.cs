using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LeaderBoard.Controllers
{
    [ApiController]
    [Route("leaderboard")]
    public class LeaderBoardController : ControllerBase
    {
        private readonly ILogger<LeaderBoardController> _logger;
        private readonly IMediator _mediator;

        public LeaderBoardController(ILogger<LeaderBoardController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }


        /// <summary>
        /// Gets the leaderboard rankings
        /// </summary>
        /// <param name="top">Number of top players to return (default: 10)</param>
        /// <param name="gameMode">Filter by specific game mode</param>
        /// <param name="fromDate">Filter entries from this date</param>
        /// <param name="toDate">Filter entries to this date</param>
        /// <returns>Leaderboard with player rankings</returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET /api/leaderboard?top=5&amp;gameMode=ranked
        ///     
        /// This endpoint returns the top players based on their scores.
        /// You can filter by date range and game mode.
        /// </remarks>
        /// <response code="200">Returns the leaderboard data</response>
        /// <response code="400">If the request parameters are invalid</response>
        [HttpGet]
        [ProducesResponseType(typeof(LeaderBoardResponse), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<LeaderBoardResponse>> GetLeaderBoard(
            [FromQuery] int? top = 10,
            [FromQuery] string? gameMode = null,
            [FromQuery] DateTime? fromDate = null,
            [FromQuery] DateTime? toDate = null)
        {
            return Ok(await _mediator.Send(new LeaderBoardQuery { PlayerId = "12345" }));
        }
    }
}
