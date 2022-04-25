using System;

namespace Lesson2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GameLeague<BasketballTeam> basketballLeague = new GameLeague<BasketballTeam>();
            GameLeague<FootballTeam> footballLeague = new GameLeague<FootballTeam>();
            basketballLeague.AddTeam(new BasketballTeam("Rytas"));
            footballLeague.AddTeam(new FootballTeam("Zalgiris"));
            footballLeague.AddTeam(new BasketballTeam("Neptunas"));

            basketballLeague.PrintAllTeams();
            footballLeague.PrintAllTeams();
        }
    }
}
