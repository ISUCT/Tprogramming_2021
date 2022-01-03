namespace CourseApp {
    using System;
    using CourseApp.Interfaces;

    using System.Collections.Generic;
    using Kantaiko.ConsoleFormatting;

    public class Program {
        public static void Main(string[] args) {


            
            Function function = new Function();
            var start = new Calculation(function);

            var a = 0.8;
            var b = 0.4;
            var xs = 1.23;
            var xe = 7.23;
            var dx = 1.2;
            var peperTaskB = new List<double>() { 1.88, 2.26, 3.84, 4.55, -6.21 };

            var peperA = start.CalculationTask(a, b, xs, xe, dx);
            var peperB = start.CalculationTask(a, b, peperTaskB);

            Console.WriteLine(Colors.FgCyan("----------Раздел A---------").BgMagenta());
            OutputTask(peperA);

            Console.WriteLine(Colors.FgCyan("----------Раздел B---------").BgMagenta());
            OutputTask(peperB);
        

        







            
            PigFamily pigOne = new Pig();
            PigFamily pigTwo = new Pig("Джорж", 9, 99);
            Warthog warthogOne = new Warthog("Стефан", 1, 5, 7);
            Warthog warthogTwo = new Warthog("Пармезан", 3, 2, 8);
            PigFamily[] animals = new PigFamily[] { pigOne, pigTwo, warthogOne, warthogTwo };
            foreach (var animal in animals) {
                Console.WriteLine(animal);
            }

            Console.Write(pigTwo.Died());
            Console.WriteLine(pigTwo.MakePhrase());
            Console.Write(warthogTwo.Died());
            Console.WriteLine(warthogTwo.MakePhrase());
            Console.WriteLine("\n--------------Zoo-------------");
            var zoologicalGarden = new ZoologicalGarden("Питерский\n");
            var user = new UserInterface();
            user.Draw(zoologicalGarden);
        }
    public static void OutputTask(List<double> listTask) {
            foreach (var y in listTask) {
                Console.WriteLine(Colors.FgCyan($"y = {y}").BgMagenta());
            }
        }
    }
}