using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableProj
{
    public class Table
    {
        public int width { get; set; }
        public int height { get; set; }
        public string wood { get; set; }

        public Table()
        {
            this.width = 0;
            this.height = 0;
            Console.WriteLine("Now you have abstract table");
        }
        public Table(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int areaOfTable()
        {
            if(this.width == 0 || this.height == 0)
            {
                Console.WriteLine("You can't count area of this table");
                return 0;
            }

            Console.WriteLine($"Area of this table: {this.width * this.height}");
            return this.width * this.height;
        }

        public bool isDishedOnTheTable()
        {
            Random rnd = new Random();
            int check = rnd.Next(0, 2);
            if(check == 1)
            {
                Console.WriteLine("Dishes on the table");
                return true;
            }
            else
            {
                Console.WriteLine("There are no dishes on the table");
                return false;
            }
        }
    }
}
