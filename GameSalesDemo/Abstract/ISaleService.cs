using GameSalesDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Abstract
{
    public interface ISaleService
    {
        void SaleImplemantation(Gamer gamer, Game game, Campaign campaign);
    }
}
