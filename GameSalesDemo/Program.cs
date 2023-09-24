using GameSalesDemo.Abstract;
using GameSalesDemo.Adapters;
using GameSalesDemo.Concrete;
using GameSalesDemo.Entity;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----Gamer------
            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "Selim", LastName = "Kaya", DateOfBirth = new DateTime(1999, 3, 2), NationalityId = "10987654321" };
            Gamer gamer2 = new Gamer() { Id = 2, FirstName = "Selma", LastName = "Kara", DateOfBirth = new DateTime(2000, 5, 2), NationalityId = "12345678910" };

            //-----Game------
            Game game1= new Game() { Id = 1 , Name = "Generals", GamePrice = 600 };
            Game game2 = new Game() { Id = 2, Name = "CounterStrike", GamePrice = 500 };
            Game game3 = new Game() { Id = 3, Name = "Need For Spped", GamePrice = 800 };
            Game game4 = new Game() { Id = 4, Name = "GTA", GamePrice = 700 };


            //-----Campaign-----
            Campaign campaign1 = new Campaign() { Id = 1, CampaignName = "YUZDE20", Discount = 20 };
            Campaign campaign2 = new Campaign() { Id = 2, CampaignName = "SUPERINDIRIM", Discount = 50 };





            
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer2);
            gamerManager.Delete(gamer1);



            
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game2);
            gameManager.Update(game3);
            


            CampaignManager campaignManager= new CampaignManager();
            campaignManager.CampaignAdd(campaign1);
            campaignManager.CampaignRemove(campaign2);




            //----------Sale Implementation ------
            Console.WriteLine("----------------------------------------------------------------------");
            SaleManager saleManager = new SaleManager();
            saleManager.SaleImplemantation(gamer1, game1, campaign1);
            


            Console.ReadLine();
        }
    }
}
