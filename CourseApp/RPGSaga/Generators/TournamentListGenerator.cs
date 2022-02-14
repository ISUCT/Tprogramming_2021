namespace CourseApp.RPGSaga.Generators
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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

        [DefaultValue(2)]
        public int ListSize
        {
            get => _listSize;

            set
            {
                if (value >= 1)
                {
                    _listSize = (int)Math.Pow(2.0, value);
                }
            }
        }

        public List<Player> GenerateTournamentList()
        {
            for (int i = 0; i < ListSize; i++)
            {
                _tournamentList.Add(_playerFabric.FactoryMethod());
            }

            return _tournamentList;
        }
    }
}