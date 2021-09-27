using System;
using System.Collections.Generic;
using AkvelonSaga.Core;

namespace AkvelonSaga.Server.GameProcess
{
    public sealed class GameSession
    {
        public GameSession(IReadOnlyList<Player> players)
        {
            Players = players;
        }
        
        public IReadOnlyList<Player> Players { get; }

        public void Start()
        {
            foreach (var player in Players)
            {
                Console.WriteLine($"[{player.Role}] {player.Name}");
            }
        }
    }
}
