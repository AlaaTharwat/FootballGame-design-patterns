using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    class Team
    {
        public ITeamStrategy TeamStrategy { get; set; }

        public Team(ITeamStrategy T)
        {
            TeamStrategy = T;
        }
        public void playGame()
        {
            TeamStrategy.play();
        }
    }
}
