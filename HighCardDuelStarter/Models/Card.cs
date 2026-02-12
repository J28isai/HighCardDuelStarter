namespace HighCardDuelStarter.Models;

public sealed class Card
{
    public required string Suit { get; init; }     // "♠", "♥", "♦", "♣"
    public required string Rank { get; init; }     // "2".."10","J","Q","K","A"
    public required int Value { get; init; }       // 2..14

    public string Display => $"{Rank}{Suit}";
}
