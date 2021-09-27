using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkvelonSaga.Server.Abstractions;

namespace AkvelonSaga.Server.GameProcess
{
    public sealed class Game
    {
        private readonly IRandomPlayerFactory _playerFactory;
        private readonly List<GameSession> _sessions = new();

        public Game(IRandomPlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }
        
        public IReadOnlyList<GameSession> Sessions => _sessions;
        
        public async Task StartSessionAsync(byte playerCount)
        {
            var players = Enumerable
                .Range(0, playerCount).Select(_ => _playerFactory.Create())
                .ToList();

            var session = new GameSession(players);
            _sessions.Add(session);
            
            await session.StartAsync();
        }
    }
}
