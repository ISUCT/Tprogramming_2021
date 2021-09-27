using System.Collections.Generic;
using System.Linq;

namespace AkvelonSaga.Server.GameProcess
{
    public sealed class Game
    {
        private readonly List<GameSession> _sessions = new();
        
        public IReadOnlyList<GameSession> Sessions => _sessions;
        
        public void StartSession(byte playerCount)
        {
            var players = Enumerable.Range(0, playerCount).Select(_ => "A").ToList();
            
            var session = new GameSession(players);
            _sessions.Add(session);
            
            session.Start();
        }
    }
}
