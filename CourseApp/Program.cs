namespace CourseApp
{
   using System;
   using CourseApp.Interfaces;
  public class Program
  {
      public static void Main(string[] args) {
           Console.WriteLine("\n--------------------Зоопарк-----------------");
           var zooNatural = new ZooNatural("Конго\n");
           var user = new UserInterface();
            user.Draw(zooNatural);
      }
  }
}