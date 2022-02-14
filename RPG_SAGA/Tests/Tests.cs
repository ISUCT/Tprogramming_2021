namespace RpgSaga;
using Xunit;
using RpgSaga.Players;
using RpgSaga.Abilities;

public class Tests
{
    [Fact]
    public void CreatePlayerTest()
    {
        var player = new Archer("Denzel");
        var ability = new FireArrows();
        Assert.Equal(player.Abilities[0].Name, ability.Name);
        Assert.Equal(player.Abilities[0].Damage, ability.Damage);
        Assert.Equal(player.Abilities[0].Duration, ability.Duration);
    }

    [Fact]
    public void WinnerTest()
    {
        Logger log = new Logger();
        FightSystem fs = new FightSystem();
        Player player1 = new Knight("Denzel");
        player1.HP = 100;
        Player player2 = new Knight("Kirill");
        player2.HP = 1;
        List<Player> tournamentPair = new List<Player>();
        tournamentPair.Add(player1);
        tournamentPair.Add(player2);
        Player winner = fs.Fight(tournamentPair, log);
        tournamentPair.Remove(winner);
        Assert.False(tournamentPair[0].CheckAlive(tournamentPair[0], log));
    }
}