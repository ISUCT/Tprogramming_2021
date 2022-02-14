namespace CourseApp.RPGSaga.GameBuilder
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Generators;
    using CourseApp.RPGSaga.Heroes;

    public class GameBuilder
    {
        private TournamentListGenerator _tournamentListGenerator;
        private List<Player> _tournamentList;
        private FightBuilder _fight;
        private int _size;

        public GameBuilder(int size)
        {
            Size = size;
            _tournamentListGenerator = new TournamentListGenerator(size);
            _tournamentList = new List<Player>();
        }

        public int Size
        {
            get => _size;

            set
            {
                if (value >= 1)
                {
                    _size = value;
                }
            }
        }

        public void StartTournament()
        {
            _tournamentList = _tournamentListGenerator.GenerateTournamentList();
            for (int i = 0; i < Size - 1; i++)
            {
                RunRound(_tournamentList);
            }

            foreach (var player in _tournamentList)
            {
                Console.WriteLine(player);
            }
        }

        public List<Player> RunRound(List<Player> players)
        {
            var playerList = players;
            _tournamentList.Clear();
            foreach (var player in playerList)
            {
                player.SetDefaultValues();
            }

            for (int i = 0; i < playerList.Count; i += 2)
            {
                _fight = new FightBuilder(playerList[i], playerList[i + 1]);
                _fight.SetTargets();
                _tournamentList.Add(_fight.StartFight());
            }

            return _tournamentList;
        }

        public void GetWinner()
        {
            Logger.WriteLog("=======================================");
            Logger.WriteLog("Winner List");
            Logger.WriteLog("=======================================");
            Console.WriteLine(_tournamentList);
        }
    }
}