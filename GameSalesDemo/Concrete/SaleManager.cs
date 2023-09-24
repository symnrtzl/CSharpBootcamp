using GameSalesDemo.Abstract;
using GameSalesDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        public void SaleImplemantation(Gamer gamer, Game game, Campaign campaign)
        {
            double Sale = (game.GamePrice - (game.GamePrice * (campaign.Discount / 100)));
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.Name + " oyununu " + campaign.CampaignName + " kampanyası ile " + Sale + "'e satın aldı. İndirimsiz Fiyat : "+ game.GamePrice);
        }
    }
}
