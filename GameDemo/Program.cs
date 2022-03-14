using System;
using GameDemo.Concrete;
using GameDemo.Entities;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player()
            {
                DateOfBirth = new DateTime(2000, 8, 9),
                FirstName = "Ad",
                Id = 1,
                IdentityNumber = 12345678910,
                LastName = "Soyad",
                Username = "hiimonur"
            };
            
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter.MernisServiceAdapter());
            playerManager.Add(player1);


            Campaign campaign1 = new Campaign()
            {
                CampaignName = "Bahar indirimleri"
            };
            GameCampaignManager gameCampaignManager = new GameCampaignManager();
            gameCampaignManager.AddCampaign(campaign1);

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sales(player1, campaign1);
        }
    }
}
