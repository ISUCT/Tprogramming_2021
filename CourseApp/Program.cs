namespace CourseApp
{
   using System;
   using System.Collections.Generic;
  
  public class Program
  {
      public static void Main(string[] args) {
           int participants = 0;
            Game start = new Game();
            participants = start.StartTheTournament(participants);
            Arena arena = new Arena();
            arena.Tour(participants);
            Console.ReadLine();
      }
  }
}