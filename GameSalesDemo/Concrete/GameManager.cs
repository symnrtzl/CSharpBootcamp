using GameSalesDemo.Abstract;
using GameSalesDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Concrete
{
    public class GameManager : IGameService
    {
        IGamerService gamerService;


        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " deleted");

        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " updated");
        }

        public void SaleGame(Game game, Gamer gamer) 
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.Name + " oyununu satın aldı.");
        }
    }
}
