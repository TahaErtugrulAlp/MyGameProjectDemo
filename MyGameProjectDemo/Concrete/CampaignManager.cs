using MyGameProjectDemo.Abstract;
using MyGameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProjectDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+"kampanyası eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "kampanyası silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "kampanyası güncellendi");
        }
    }
}
