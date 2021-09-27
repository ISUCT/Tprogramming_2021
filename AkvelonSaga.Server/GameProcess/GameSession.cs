using System;
using System.Collections.Generic;

namespace AkvelonSaga.Server.GameProcess
{
    public sealed class GameSession
    {
        public GameSession(IReadOnlyList<string> players)
        {
            Players = players;
        }
        
        public IReadOnlyList<string> Players { get; }

        public void Start()
        {
            foreach (var player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
