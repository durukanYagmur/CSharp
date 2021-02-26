using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManage : ISaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.gamerName + "has bought the " + game.gameName + " game using " + campaign.campaignName + " campaign");
        }
    }
}
