using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" " + gamer.LastName +" adlı oyuncu sisteme eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" "+ gamer.LastName + " adlı oyuncu sistemden silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu bilgileri güncellendi");
        }
    }
}
