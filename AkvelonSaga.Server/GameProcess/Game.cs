﻿using System.Linq;
using System.Threading.Tasks;
using AkvelonSaga.Server.Abstractions;

namespace AkvelonSaga.Server.GameProcess
{
    internal sealed class Game
    {
        private readonly IRandomPlayerFactory _playerFactory;

        public Game(IRandomPlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }
        
        public async Task StartSessionAsync(byte groupCount)
        {
            var players = Enumerable.Range(0, groupCount * 2)
                .Select(_ => _playerFactory.Create())
                .ToList();

            var session = new GameSession(players);
            await session.StartAsync();
        }
    }
}
