namespace RpgSaga.Players;
using RpgSaga.Abilities;
public abstract class Player
{
    public Player(string name, int hp, int strenght)
    {
        this.Name = name;
        this.MaxHP = this.HP = hp;
        this.Strenght = strenght;
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

    public bool CheckAlive(Player player)
    {
        if (HP < 1)
        {
            Logger.Death(player);
            return false;
        }
        else
        {
            return true;
        }
    }

    public void RefreshBuffs(Player player) // переписать
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