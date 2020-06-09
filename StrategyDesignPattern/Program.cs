using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Team Team = new Team(new DefenceStrategy());
            Console.WriteLine($"Start Game with!");
            Team.playGame();

            Console.WriteLine("Change the strategy");
            Team.TeamStrategy = new AttackStrategy();
            Team.playGame();

            Console.WriteLine("Change the strategy");
            Team.TeamStrategy = new AttackDefenceStrategy();
            Team.playGame();
        }
    }
}
