using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            /*DMFC R = new DMFC("Барбара", "Борис", "Бэлла", "Владимир");
            R.Print();
            R.Tir();

            MFC D = new MFC("Барбара", "Борис", "Бэлла");
            D.Print();
            D.Tir();

            VMFC O = new VMFC("Владимир", "Солнце", "Катя", "Мария", "Волковы");
            O.Print();
            O.Tir();

            Console.WriteLine("Дети: " + R.GetChild());
            Console.WriteLine("Дети: " + D.GetChild());
            Console.WriteLine("Дети: " + O.GetChild());
            Console.WriteLine("Фамилия: " + O.GetName());*/


            Population P = new Population(1);
            Console.Write("Задайте имя ребенка для поиска или укажите 'все': ");
            string name = Console.ReadLine();
            P.OutputResult(name);
            
            P = new Population(2);
            Console.Write("Задайте имя ребенка для поиска или укажите 'все': ");
            name = Console.ReadLine();
            P.OutputResult(name);

            Console.ReadKey();

        }
    }
}
