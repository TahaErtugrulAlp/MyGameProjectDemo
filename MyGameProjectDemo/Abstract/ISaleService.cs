using MyGameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProjectDemo.Abstract
{
    public interface ISaleService
    {
        void Sale(Game game,Gamer gamer,Campaign campaign);

    }
}
