﻿using GameSalesDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Abstract
{
    public interface ICampaignService
    {
        void CampaignAdd(Campaign campaign);

        void CampaignRemove(Campaign campaign);
    }
}
