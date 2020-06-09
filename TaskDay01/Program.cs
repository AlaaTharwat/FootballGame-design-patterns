using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start!!");

            Football football = new Football();
            Player player1 = new Player("player1", football);
            Player player2 = new Player("player2", football);
            Player player3 = new Player("player3", football);
            Player player4 = new Player("player4", football);
            Referee referee = new Referee("Referee", football);

            football.attachObserver(player1);
            football.attachObserver(player2);
            football.attachObserver(player3);
            football.attachObserver(player4);
            football.attachObserver(referee);



            football.position = new Position() { X = 10, Y = 2, Z = 7 };

            football.dettachObserver(player1);

            football.position = new Position() { X = 22, Y = 12, Z = 25 };

            Player player5 = new Player("player5", football);
            football.attachObserver(player5);

            football.position = new Position() { X = 29, Y = 12, Z = 25 };

        }
    }
}
