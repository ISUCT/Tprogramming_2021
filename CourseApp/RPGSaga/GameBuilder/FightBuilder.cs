namespace CourseApp.RPGSaga.GameBuilder
{
    using CourseApp.RPGSaga.Heroes;

    public class FightBuilder
    {
        private Player _p1;
        private Player _p2;
        private Player _winner;
        private Player _looser;

        public FightBuilder(Player p1, Player p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public Player StartFight()
        {
            Logger.WriteLog($"Fight: {_p1.ToString()} against {_p2.ToString()}");
            while (!_p1.IsDead && !_p2.IsDead)
            {
                _p1.SetTarget(_p2);
                _p1.MakeAMove();
                _p2.SetTarget(_p1);
                _p2.MakeAMove();
            }

            if (_p1.IsDead)
            {
                _looser = _p1;
                _winner = _p2;
            }
            else
            {
                _looser = _p2;
                _winner = _p1;
            }

            Logger.WriteLog($"Winner of this match is {_winner.ToString()}");
            Logger.WriteLog($"Such a good victory against {_looser.ToString()}");
            return _winner;
        }
    }
}