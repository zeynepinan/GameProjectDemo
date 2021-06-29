using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CheckPersonManager : ICheckPersonService
    {
        public bool CheckOfRealPerson(Gamer gamer)
        {
            if (gamer.NationalityId.Length == 11)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
