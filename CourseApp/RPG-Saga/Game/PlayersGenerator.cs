using System.Collections.Generic;

namespace CourseApp.RPG_Saga.Game
{
    public abstract class PlayersGenerator
    {
        public List<Player> Players(int count)
        {
            List<Player> tempPlayers = new List<Player>();
            tempPlayers.Add(new Archer());


        }
    }
}
