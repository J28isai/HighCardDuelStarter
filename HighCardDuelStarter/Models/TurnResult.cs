namespace HighCardDuelStarter.Models;

public sealed class TurnResult
{
    public int TurnNumber { get; init; }
    public required string Player1Card { get; init; }
    public required string Player2Card { get; init; }
    public required string Winner { get; init; } // name or "Tie"

    public required string Summary { get; init; }
}
