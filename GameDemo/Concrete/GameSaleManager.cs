using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class GameSaleManager:IGameSaleService
    {
        public void Sales(Player player, Campaign campaign)
        {
            Console.WriteLine(player.Username + " isimli oyuncu " + campaign.CampaignName + 
                              " kampanyasından yararlanarak satış yaptı!");
        }
    }
}
