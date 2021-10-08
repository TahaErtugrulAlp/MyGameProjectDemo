using MyGameProjectDemo.Concrete;
using MyGameProjectDemo.Entities;
using System;

namespace MyGameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game {Id=1,Name="Witcher 3",Price=50,UnitsInStock=500};
            Game game2 = new Game {Id=2,Name="Gta 5 ",Price=100,UnitsInStock=5000};

            Gamer gamer1 = new Gamer {Id=1,FirstName="Ertuğrul",LastName="Alp",BirthYear=2002,IdentifyNumber= "5453252362" };
            Gamer gamer2 = new Gamer {Id=2,FirstName="Ecem",LastName="Özcan",BirthYear=1990,IdentifyNumber= "48541887854" };

            Campaign campaign = new Campaign{ Id=1,Name="Summer Sale",Discount=40};


            GameManager gameManger = new GameManager();
            gameManger.Add(game);
            gameManger.Delete(game2);
            gameManger.Update(game);


            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);
            gameManger.Update(game);


            CampaignManager campaignManager = new  CampaignManager();
            campaignManager.Add(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game,gamer1,campaign);

           
            

        }

      
    }
}
