namespace RpgSaga.Players;
using RpgSaga.Abilities;
public abstract class Player
{
    public Player(string name)
    {
        Random rnd = new Random();
        this.Name = name;
        this.MaxHP = rnd.Next(12, 21);
        this.HP = this.MaxHP;
        this.Strenght = rnd.Next(2, 6);
        this.Buffs = new List<Ability>();
        this.Abilities = new List<Ability>();
    }

    public List<Ability> Abilities { get; set; }

    public List<Ability> Buffs { get; set; }

    public string Name { get; set; }

    public int HP { get; set; }

    public int MaxHP { get; set; }

    public int Strenght { get; set; }

    public void ResetStats()
    {
        HP = MaxHP;
        Buffs.Clear();
    }

    public bool CheckAlive(Player player, Logger log)
    {
        if (HP < 1)
        {
            return false;
        }
        else
        {
            log.Death(player);
            return true;
        }
    }

    public void RefreshBuffs(Player player)
    {
        foreach (var buff in Buffs)
        {
            if (buff.Duration < 1)
            {
                Buffs.Remove(buff);
            }
            else
            {
                buff.UseBuff(player);
                buff.Duration--;
            }
        }
    }
}