namespace CourseApp.Zoo
{
    public class Shovel : Staff
    {
        private int number = -1;

        public Shovel(int id, int number)
            : base(id)
        {
            if (number > 0)
            {
                this.number = number;
            }
        }

        public string GetSh()
        {
            return $"{GetID()}||Number: {(number == -1 ? "ERROR 404" : $"{number}")}";
        }
    }
}
