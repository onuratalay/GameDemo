using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class PlayerManager:IPlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                Console.WriteLine(player.Username + " isimli oyuncu kayıt EDİLMİŞTİR!");
            }
            else
            {
                Console.WriteLine(player.Username + " isimli oyuncu HATALI bilgiler girdiği için kayıt EDİLEMEMİŞTİR!");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.Username + " isimli oyuncu silinmiştir!");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.Username + " isimli oyuncu güncellenmiştir!");
        }
    }
}
