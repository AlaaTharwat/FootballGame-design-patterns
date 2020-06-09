using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class PlayerRole : Player
    {
        public Player player;

        public override void PassBall()
        {
            Console.WriteLine($"Player {player.Name} pass the ball");
        }
        public void AssignPlayer(Player p)
        {
            player = p;
        }
    }

    class Forward : PlayerRole
    {

        public void ShootBall()
        {
            Console.WriteLine($"Forward {base.Name} shooting the ball");
        }
    }

    class MidFielder : PlayerRole
    {

        public void Dribble()
        {
            Console.WriteLine($"MidFielder {base.Name} Dribbling the ball");
        }
    }

    class Defender : PlayerRole
    {

        public void Defend()
        {
            Console.WriteLine($"Defender {base.Name} Defending");
        }
    }

}
