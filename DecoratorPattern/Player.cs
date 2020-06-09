using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Player
    {
        public String Name { get; set; }
        public abstract void PassBall();

    }

    class FieldPlayer : Player
    {
        public FieldPlayer(String Name)
        {
            base.Name = Name;
        }
        public override void PassBall()
        {
            Console.WriteLine($"FieldPlayer {Name} pass ball");
        }
    }

    class GoalKeeper : Player
    {
        public GoalKeeper(String Name)
        {
            base.Name = Name;
        }
        public override void PassBall()
        {
            Console.WriteLine($"GoalKeeper{Name} pass ball");
        }
    }
}
