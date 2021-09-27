using System;
using System.Collections.Generic;
using System.Linq;
using AkvelonSaga.Core.Roles;

namespace AkvelonSaga.Server.GameProcess
{
    public sealed class Game
    {
        private readonly IRoleStorage _roleStorage;
        private readonly List<GameSession> _sessions = new();

        public Game(IRoleStorage roleStorage)
        {
            _roleStorage = roleStorage;
        }
        
        public IReadOnlyList<GameSession> Sessions => _sessions;
        
        public void StartSession(byte playerCount)
        {
            foreach (var role in _roleStorage.Roles)
            {
                Console.WriteLine(role);
            }
            
            var players = Enumerable.Range(0, playerCount).Select(_ => "A").ToList();
            
            var session = new GameSession(players);
            _sessions.Add(session);
            
            session.Start();
        }
    }
}
