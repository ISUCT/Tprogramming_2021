using System.Collections.Generic;
using AkvelonSaga.Core;

namespace AkvelonSaga.Server.GameProcess
{
    internal sealed class TurnManager
    {
        private readonly IReadOnlyList<PlayerState> _players;
        private int _position;

        public TurnManager(IReadOnlyList<PlayerState> players)
        {
            _players = players;
        }

        public PlayerState Sender => Peek(0);

        public PlayerState Target => Peek(1);

        public void NextTurn()
        {
            _position = (_position + 1) % _players.Count;
        }

        private PlayerState Peek(int offset)
        {
            var index = (_position + offset) % _players.Count;
            return _players[index];
        }
    }
}
