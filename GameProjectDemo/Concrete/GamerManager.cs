using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        ICheckPersonService _checkPersonService;

        public GamerManager(ICheckPersonService checkPersonService)
        {
            _checkPersonService = checkPersonService;
        }

        public void Add(Gamer gamer)
        {
            if (_checkPersonService.CheckOfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu sisteme eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama yapılamadı.");
            }
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
