namespace CourseApp.RPG_Saga
{
    using System;
    using CourseApp.RPG_Saga.GameLogic;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество игроков (доступны значения 2, 4, 8, 16, 32, 64..):");

            int numOfPlayers = int.Parse(Console.ReadLine());

            Console.WriteLine($"+--------------------------------------------------------------+\n" +
                $"Игра началась с количеством игроков {numOfPlayers}!\n" +
                $"+--------------------------------------------------------------+\n");

            Game.StartGame(numOfPlayers);
        }
    }
}