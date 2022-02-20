namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int tournamentParticipants = 0;
            Game start = new Game();
            tournamentParticipants = start.StartTheTournament(tournamentParticipants);
            Scene scene = new Scene();
            scene.Tournament(tournamentParticipants);
            Console.ReadLine();
        }
    }
}