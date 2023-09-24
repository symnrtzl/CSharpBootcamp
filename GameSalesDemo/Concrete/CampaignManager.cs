using GameSalesDemo.Abstract;
using GameSalesDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " added.");
        }

        public void CampaignRemove(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " deleted.");
        }
    }
}
