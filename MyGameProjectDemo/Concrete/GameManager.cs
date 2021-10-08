using MyGameProjectDemo.Abstract;
using MyGameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProjectDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name +" adlı oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun güncellendi");
        }
    }
}
