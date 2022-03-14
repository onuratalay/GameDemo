using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    interface IGameCampaignService
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
    }
}
