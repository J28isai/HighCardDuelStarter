using HighCardDuelStarter.Models;

namespace HighCardDuelStarter.Repositories;

public interface IGameSessionRepository
{
    GameSession Get();
    void Save(GameSession session);
    void Reset();
}
