using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    interface IObserver
    {
        void update();
    }

    class Player : IObserver
    {
        String playerName;
        Football ball;
        public Player(String Name , Football _ball)
        {
            playerName = Name;
            ball = _ball;
        }
        public void update()
        {
            Console.WriteLine($"{playerName} Will Move to Ball Position {ball.position}!");
        }
    }

    class Referee : IObserver
    {
        String RefreeName;
        Football ball;

        public Referee(String Name, Football _ball)
        {
            RefreeName = Name;
            ball = _ball;
        }

        public void update()
        {
            Console.WriteLine($"{RefreeName} Will Move to Ball Position {ball.position}!");
        }
    }
}
