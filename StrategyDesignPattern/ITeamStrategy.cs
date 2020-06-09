using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    interface ITeamStrategy
    {
        void play();
    }

    class DefenceStrategy : ITeamStrategy
    {
        public void play()
        {
            Console.WriteLine($"Team is barking the bus !!");
        }
    }

    class AttackStrategy : ITeamStrategy
    {
        public void play()
        {
            Console.WriteLine($"Team is playing TIKI TAKA!!");
        }
    }

    class AttackDefenceStrategy : ITeamStrategy
    {
        public void play()
        {
            Console.WriteLine($"Team is playing Both!!");
        }
    }

}
