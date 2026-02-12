using HighCardDuelStarter.Models;

namespace HighCardDuelStarter.Repositories;

public sealed class InMemoryGameSessionRepository : IGameSessionRepository
{
    private GameSession _session = new();

    public GameSession Get() => _session;

    public void Save(GameSession session)
    {
        // In-memory: store reference (or clone if you prefer immutability)
        _session = session;
    }

    public void Reset()
    {
        _session = new GameSession();
    }
}
