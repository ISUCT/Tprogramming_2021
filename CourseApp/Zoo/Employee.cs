namespace CourseApp.Zoo
{
    public abstract class Employee : IDraw
    {
        private string name;
        private string sname;
        private int age = -1;
        private int exp = -1;

        public Employee(string name, string secodname, int age, int exp)
        {
            this.name = name;
            sname = secodname;
            if (age > 0)
            {
                this.age = age;
            }

            if (exp > -1)
            {
                this.exp = exp;
            }
        }

        public string Draw()
        {
            return $"{name} {sname}: Age: {(age == -1 ? "missing" : $"{age} years")}||Exp: {(exp == -1 ? "missing" : $"{exp} years")} \n";
        }
    }
}
