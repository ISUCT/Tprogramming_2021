namespace RPGsaga.Player
{
    public interface IPlayer
    {
        string Name { get; set; }

        double Health { get; set; }

        double Strength { get; set; }
    }
}