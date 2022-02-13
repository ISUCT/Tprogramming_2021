namespace RpgSaga;
using RpgSaga.Players;

public class FightSystem{
    Random rnd = new Random();
    public int attack; //0-default attack
    public Player fight(List<Player> tournamentPair, Logger log){
        foreach (Player player in tournamentPair){
            player.resetStats();
        }
        while (tournamentPair.Count != 1){
            for (int j = 0; j != 2; j++){
                foreach (Player player in tournamentPair){
                    player.refreshBuffs(player);
                    if (!player.checkAlive()){
                        tournamentPair.Remove(player);
                        return(tournamentPair[0]);
                    }
                }

                if (tournamentPair[0].buffs.Find(buff => buff.stun) != null){
                    var ability = tournamentPair[0].abilities[0];
                    tournamentPair[0].abilities.Remove(ability);
                    attack = rnd.Next(0,2);
                    if (attack == 0){
                        ability.attack(tournamentPair, log);
                    }
                    else{
                        ability.useAbility(tournamentPair, log);
                    }
                    tournamentPair[0].abilities.Add(ability);
                }

                if (!tournamentPair[1].checkAlive()){
                    return(tournamentPair[0]);
                }

                Player temp = tournamentPair[0];
                tournamentPair[0] = tournamentPair[1];
                tournamentPair[1] = temp;
            }
        }
        Console.WriteLine("Произошёл прикол");
        return(tournamentPair[0]);
    }
}