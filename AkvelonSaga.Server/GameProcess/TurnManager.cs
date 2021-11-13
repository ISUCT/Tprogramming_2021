using System.Collections.Generic;
using System.Collections.Immutable;

namespace AkvelonSaga.Server.GameProcess
{
    internal sealed class TurnManager
    {
        private readonly ImmutableArray<PlayerState> _players;
        private int _position;

        public TurnManager(IEnumerable<PlayerState> players)
        {
            _players = ImmutableArray.CreateRange(players);
        }

        public PlayerState Sender => Peek(0);

        public PlayerState Target => Peek(1);

        public void NextTurn()
        {
            _position = (_position + 1) % _players.Length;
        }

        private PlayerState Peek(int offset)
        {
            var index = (_position + offset) % _players.Length;
            return _players[index];
        }
    }
}
