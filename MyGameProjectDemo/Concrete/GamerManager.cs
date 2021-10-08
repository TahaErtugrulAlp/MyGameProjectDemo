using MyGameProjectDemo.Abstract;
using MyGameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" "+ gamer.LastName + " adlı oyuncu eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " +gamer.LastName + " adlı oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " "+ gamer.LastName + " adlı oyuncu güncellendi");
        }
    }
}
