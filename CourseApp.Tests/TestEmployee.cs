using System;
using Xunit;
using EmployeeClass;
using System.Threading;

namespace TestEmployee
{
    public class TestEmployee
    {
        [Fact]
        public void timeSpentFromGettingAJob_return2Seconds()
        {
            Employee emp = new Employee();

            Thread.Sleep(2000);

            TimeSpan totalSeconds = emp.timeSpentFromGettingJob();

            double res = Math.Round(totalSeconds.TotalSeconds);

            int seconds = 2;

            Assert.Equal(seconds, res);
        }

        [Fact]
        public void getJob_returns_Lvl1_2_3()
        {
            Employee emp = new Employee();

            string res = emp.getJob();

            if(res == "Lvl 1")
            {
                Assert.Equal(res, "Lvl 1");
            }
            else if(res == "Lvl 2")
            {
                Assert.Equal(res, "Lvl 2");
            }
            else
            {
                Assert.Equal(res, "Lvl 3");
            }
        }

        [Fact]
        public void getSalery_returns_1000_2000_3000()
        {
            Employee emp = new Employee();

            int res = emp.getSalary();

            if(emp.job == "Lvl 1")
            {
                Assert.Equal(1000, res);
            }
            else if(emp.job == "Lvl 2")
            {
                Assert.Equal(2000, res);
            }
            else
            {
                Assert.Equal(3000, res);
            }
            
        }
    }
}
