namespace CourseApp.Zoo
{
    public class Track : Staff, IDraw
    {
        private int number = -1;

        public Track(int id, int number)
            : base(id)
        {
            if (number > 0)
            {
                this.number = number;
            }
        }

        public string Draw()
        {
            return $"{GetID()} Track number {(number == -1 ? "ERROR 404" : $"{number}")}";
        }
    }
}
