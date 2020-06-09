using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
     abstract class Ball
    {
        private List<IObserver> observers = new List<IObserver>();
        public void attachObserver(IObserver O)
        {
            observers.Add(O);
        }
        public void dettachObserver(IObserver O)
        {
            observers.Remove(O);
        }

        public void notifyObserver()
        {
            foreach (var o in observers)
            {
                o.update();
            }
        }

    }

     class Football : Ball
    {
        private Position _Position = new Position();

        public Position position 
        {
            get { return _Position; }
            set
            {
                _Position = value;
                Console.WriteLine($"Ball new posion is {position}");
                notifyObserver();
            }
        }
    }
}
