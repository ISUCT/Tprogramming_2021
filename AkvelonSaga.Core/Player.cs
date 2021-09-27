namespace AkvelonSaga.Core
{
    public abstract class Player
    {
        protected Player(string role, string name, double health, double attack)
        {
            Role = role;
            Name = name;
            Health = health;
            Attack = attack;
        }
        
        public string Role { get; }
        
        public string Name { get; }
        
        public double Health { get; }
        
        public double Attack { get; }
    }
}
