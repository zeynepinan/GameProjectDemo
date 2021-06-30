using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			Gamer gamer = new Gamer();
			gamer.Id = 1;
			gamer.FirstName = "Zeynep";
			gamer.LastName = "İnan";
			gamer.NationalityId = "111111111";
			gamer.Email = "zey@gmail.com";
			gamer.Password = "zey";
			gamer.DateOfBirth = new DateTime(1998, 2, 10);


			GamerManager gamerManager = new GamerManager(new CheckPersonManager());
			gamerManager.Add(gamer);
			gamerManager.Delete(gamer);
			gamerManager.Update(gamer);

			Campaign campaign = new Campaign();
			campaign.CampaignName = "Yaz İndirimi";
			campaign.CampaignRate = 50;
			campaign.UnitPrice = 150;

			Campaign campaign1 = new Campaign();
			campaign1.CampaignName = "Hafta Sonu İndirimi";
			campaign1.CampaignRate = 25;
			campaign1.UnitPrice = 650;


			CampaignManager campaignManager = new CampaignManager();
			campaignManager.Add(campaign);
			campaignManager.Delete(campaign);
			campaignManager.Update(campaign);


			Game game1 = new Game {Id= 1, GameName="PubG",GamePrice= 15 };
			Game game = new Game { Id = 2, GameName = "CSGO", GamePrice= 150 };

			GameManager gameManager = new GameManager();
			gameManager.Add(game1);
			gameManager.Delete(game1);
			gameManager.Update(game1);
			gameManager.Add(game);
			gameManager.Delete(game);
			gameManager.Update(game);

			SaleManager saleManager = new SaleManager();
			saleManager.Sale(gamer, game1);
			saleManager.CampaignSale(gamer, game, campaign); 
			saleManager.CampaignSale(gamer, game, campaign1);
		}
    }
}
