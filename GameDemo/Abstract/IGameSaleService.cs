using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    interface IGameSaleService
    {
        void Sales(Player player, Campaign campaign);
    }
}
