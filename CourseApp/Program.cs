using System;
namespace CourseApp
{
<<<<<<< HEAD
    using System;
    using CourseApp.Interfaces;

    public class Program
    {
       public static void Main(string[] args)
       {
            Console.WriteLine(pigTwo.MakePhrase());
            Console.Write(boarTwo.Died());
            Console.WriteLine(boarTwo.MakePhrase());
            Console.WriteLine("\n--------------------Зоопарк-----------------");
            var zoologicalGarden = new ZoologicalGarden("Фурмановский\n");
            var user = new UserInterface();
            user.Draw(zoologicalGarden);
        }
    }
