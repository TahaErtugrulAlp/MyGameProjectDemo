using MyGameProjectDemo.Abstract;
using MyGameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProjectDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName+" isimli oyuncu "+ game.Name+
                " isimli oyunu "+ campaign.Name +" kampanyasını kullanarak satın almıştır");
        }
    }
}
