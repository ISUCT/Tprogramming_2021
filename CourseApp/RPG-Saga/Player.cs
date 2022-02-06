namespace CourseApp.RPG_Saga
{
    public abstract class Player
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int Strenght { get; set; }

        public void ApplyDamage(Player player)
        {
            player.Health -= Strenght;
        }
    }
}
