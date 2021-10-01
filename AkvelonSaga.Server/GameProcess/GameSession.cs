using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkvelonSaga.Core;

namespace AkvelonSaga.Server.GameProcess
{
    internal sealed class GameSession
    {
        private static readonly Random Random = new();

        public GameSession(IReadOnlyList<Player> players)
        {
            Players = players;
        }

        public IReadOnlyList<Player> Players { get; }

        public async Task StartAsync()
        {
            var groups = Players
                .OrderBy(_ => Random.Next())
                .Select((s, i) => new
                {
                    Value = new PlayerState(s),
                    Index = i
                })
                .GroupBy(o => o.Index / 2)
                .Select(s => s.Select(x => x.Value).ToArray())
                .ToArray();

            foreach (var group in groups)
            {
                var turnManager = new TurnManager(group);

                Console.WriteLine($"{turnManager.Sender} vs {turnManager.Target}");

                while (group.Count(x => x.Health > 0) != 1)
                {
                    await Task.Delay(2000);

                    var (sender, target) = (turnManager.Sender, turnManager.Target);

                    Console.WriteLine($"{sender} наносит {sender.Player.Attack} урона противнику {target}");

                    target.ApplyDamage(sender.Player.Attack);
                    turnManager.NextTurn();
                }

                var winner = group.First(x => x.Health > 0);

                Console.WriteLine($"{winner} побеждает");
            }
        }
    }
}
