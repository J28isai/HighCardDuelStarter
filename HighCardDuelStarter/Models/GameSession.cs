using System.Collections.ObjectModel;

namespace HighCardDuelStarter.Models;

public sealed class GameSession
{
    public string Player1Name { get; set; } = "Player 1";
    public string Player2Name { get; set; } = "Player 2";

    public int Player1Score { get; set; }
    public int Player2Score { get; set; }

    public int TurnNumber { get; set; }

    public string Player1CurrentCard { get; set; } = "-";
    public string Player2CurrentCard { get; set; } = "-";

    public string LastTurnSummary { get; set; } = "Press Draw Turn to start.";

    public ObservableCollection<TurnResult> History { get; } = new();
}
