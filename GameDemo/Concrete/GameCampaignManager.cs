using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class GameCampaignManager:IGameCampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya eklenmiştir!");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya silinmiştir!");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya güncellenmiştir!");
        }
    }
}
