using MediatR;
public class LeaderBoardQuery : IRequest<LeaderBoardResponse>
{
    /// <summary>
    /// Gets or sets the player ID for which to retrieve the leaderboard information.
    /// </summary>
    /// <example>12345</example>
    public string PlayerId { get; set; }
}

public class LeaderBoardResponse
{
    /// <summary>
    /// Gets or sets the player ID for which to retrieve the leaderboard information.
    /// </summary>
    /// <example>12345</example>
    public string PlayerId { get; set; }
    public int Score { get; set; }
    public int Rank { get; set; }
}

public class LeaderBoardQueryHandler : IRequestHandler<LeaderBoardQuery, LeaderBoardResponse>
{
    public LeaderBoardQueryHandler()
    {
    }

    public async Task<LeaderBoardResponse> Handle(LeaderBoardQuery request, CancellationToken cancellationToken)
    {
        return new LeaderBoardResponse
        {
            PlayerId = request.PlayerId,
            Score = 100,
            Rank = 1
        };
    }
}