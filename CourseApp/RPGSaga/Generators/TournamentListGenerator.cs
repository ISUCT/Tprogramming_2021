namespace CourseApp.RPGSaga.Generators
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Heroes;
    using CourseApp.RPGSaga.Interfaces;

    public class TournamentListGenerator : ITournamentListGenerator
    {
        private int _listSize;
        private PlayerFabric _playerFabric;
        private List<Player> _tournamentList;

        public TournamentListGenerator(int listSize)
        {
            ListSize = listSize;
            _playerFabric = new PlayerFabric();
            _tournamentList = new List<Player>();
        }

        public int ListSize
        {
            get
            {
                return _listSize;
            }

            set
            {
                if (value >= 2 && value % 2 == 0)
                {
                    _listSize = value;
                }
                else
                {
                    Console.WriteLine("incorrect value");
                }
            }
        }

        public List<Player> GenerateTournamentList()
        {
            for (int i = 0; i < _listSize; i++)
            {
                _tournamentList.Add(_playerFabric.FactoryMethod());
            }

            return _tournamentList;
        }
    }
}