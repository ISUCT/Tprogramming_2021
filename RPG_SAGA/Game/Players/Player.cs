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
            log.Death(player);
            return false;
        }
        else
        {
            return true;
        }
    }

    public void RefreshBuffs(Player player)
    {
        List<Ability> expired = new List<Ability>();
        foreach (var buff in Buffs)
        {
            if (buff.Duration < 1)
            {
                expired.Add(buff);
            }
            else
            {
                buff.UseBuff(player);
                buff.Duration--;
            }
        }

        foreach (var buff in expired)
        {
            Buffs.Remove(buff);
        }
    }
}