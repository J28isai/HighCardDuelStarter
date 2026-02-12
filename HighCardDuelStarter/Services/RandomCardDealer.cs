using HighCardDuelStarter.Models;

namespace HighCardDuelStarter.Services;

public sealed class RandomCardDealer : ICardDealer
{
    private static readonly string[] Suits = ["♠", "♥", "♦", "♣"];
    private static readonly (string Rank, int Value)[] Ranks =
    [
        ("2", 2), ("3", 3), ("4", 4), ("5", 5), ("6", 6),
        ("7", 7), ("8", 8), ("9", 9), ("10", 10),
        ("J", 11), ("Q", 12), ("K", 13), ("A", 14)
    ];

    private readonly Random _rng = new();

    public Card DrawCard()
    {
        var suit = Suits[_rng.Next(Suits.Length)];
        var (rank, value) = Ranks[_rng.Next(Ranks.Length)];

        return new Card
        {
            Suit = suit,
            Rank = rank,
            Value = value
        };
    }
}
