using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    public class Employee
    {
        string name;
        int age;
        DateTime date;
        public string job;
        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.date = DateTime.Now;
            this.job = getJob();
        }

        public Employee()
        {
            this.name = null;
            this.age = 0;
            this.date = DateTime.Now;
            this.job = getJob();
        }

        public TimeSpan timeSpentFromGettingJob()
        {
            DateTime now = DateTime.Now;
            return now - this.date;
        }

        public string getJob()
        {
            Random rand = new Random();
            int res = rand.Next(1, 4);

            if(res == 1)
            {
                return "Lvl 1";
            }
            else if(res == 2)
            {
                return "Lvl 2";
            }
            else
            {
                return "Lvl 3";
            }
        }

        public int getSalary()
        {
            int standardSalary = 1000;

            if(this.job == "Lvl 1")
            {
                return standardSalary;
            }
            else if(this.job == "Lvl 2")
            {
                return standardSalary * 2;
            }
            else
            {
                return standardSalary * 3;
            }
        }
    }
}
