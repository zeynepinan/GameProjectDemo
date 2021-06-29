using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı kampanya sisteme eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı kampanya sistemden silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı kampanya güncellendi");
        }
    }
}
