namespace CourseApp.Zoo
{
    public class Cage : Staff, IDraw
    {
        private int number = -1;
        private Creature occupant;

        public Cage(int id, int number)
            : base(id)
        {
            if (number > 0)
            {
                this.number = number;
            }
        }

        public string Draw()
        {
            return $"In cage {GetID()} #{number}: {occupant.Draw()}\n";
        }

        public void SetOc(Creature oc)
        {
            occupant = oc;
        }
    }
}
