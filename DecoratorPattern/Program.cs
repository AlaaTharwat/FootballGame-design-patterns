using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Forward forward = new Forward();
            forward.Name = "P1";
            forward.AssignPlayer(forward);
            MidFielder midfielder = new MidFielder();
            midfielder.Name = "P2";
            midfielder.AssignPlayer(midfielder);

            GoalKeeper goalKeeper = new GoalKeeper("G");
            goalKeeper.PassBall();


       
            forward.PassBall();
            forward.ShootBall();
            midfielder.PassBall();
            midfielder.Dribble();

        }
    }
}
