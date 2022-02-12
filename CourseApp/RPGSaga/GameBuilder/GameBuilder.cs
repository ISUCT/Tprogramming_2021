namespace CourseApp.RPGSaga.GameBuilder
{
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Generators;
    using CourseApp.RPGSaga.Heroes;

    public class GameBuilder
    {
        private int _listSize = 4;
        private TournamentListGenerator _tournamentListGenerator;
        private List<Player> _tournamentList;
        private List<Player> _winners;
        private FightBuilder _fight;

        public GameBuilder()
        {
            _tournamentListGenerator = new TournamentListGenerator(_listSize);
            _tournamentList = new List<Player>();
            _winners = new List<Player>();
        }

        public void StartTournament()
        {
            _tournamentList = _tournamentListGenerator.GenerateTournamentList();
            RunRound(_tournamentList);
        }

        public List<Player> RunRound(List<Player> players)
        {
            for (int i = 1; i < players.Count; i += 2)
            {
                _fight = new FightBuilder(players[i - 1], players[i]);
            }
        }
    }
}