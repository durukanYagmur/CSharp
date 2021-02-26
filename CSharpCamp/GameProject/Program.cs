using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { gameName = "Fall Guys", gamePrice = 14, releasedDate = new System.DateTime(2020, 08, 10) };
            Game game2 = new Game() { gameName = "Age Of Empires", gamePrice = 35.5, releasedDate = new System.DateTime(2018, 04, 24) };
            Game game3 = new Game() { gameName = "GTA 4", gamePrice = 128.4, releasedDate = new System.DateTime(2019, 06, 02) };

            Gamer gamer1 = new Gamer() { gamerName = "Yağmur", gamerSurname = "Durukan", dateOfBirth = new System.DateTime(1999, 03, 30), gamerTC = "30514947508" };
            Gamer gamer2 = new Gamer() { gamerName = "Eda", gamerSurname = "Durukan", dateOfBirth = new System.DateTime(1973, 11, 27), gamerTC = "30517047444" };

            Campaign campaign1 = new Campaign() { campaignName = "Valentines Day", campaignDuration = 15, campaignRate = 50 };
            Campaign campaign2 = new Campaign() { campaignName = "New Year", campaignDuration = 30, campaignRate = 25 };



            CampaignManage campaignManage = new CampaignManage();
            GamerManage gamerManage = new GamerManage(new UserValidationManage());
            SalesManage salesManage = new SalesManage();
            GameManager gameManager = new GameManager();

            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            gamerManage.Registry(gamer1);
            gamerManage.Registry(gamer2);

            campaignManage.NewCampaign(campaign1);
            campaignManage.NewCampaign(campaign2);

            salesManage.Sale(gamer1, game1, campaign1);
            salesManage.Sale(gamer2, game3, campaign2);

            gamerManage.Update(gamer2);

            campaignManage.DeleteCampaign(campaign2);
        }
    }
}
