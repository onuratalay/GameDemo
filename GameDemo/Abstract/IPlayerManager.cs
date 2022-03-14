using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface IPlayerManager
    {
        void Add(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}
