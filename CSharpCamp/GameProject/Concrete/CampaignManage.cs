using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManage : ICampaignService
    {
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign is deleted");
        }

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign is added");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign is updated");
        }
    }
}
