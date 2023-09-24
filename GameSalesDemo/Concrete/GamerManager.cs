using GameSalesDemo.Abstract;
using GameSalesDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Delete(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " deleted");
            }
            else
            {
                //throw new Exception("Not a valid person");
                //Console.WriteLine(gamer.FirstName + " Not a valid person");
            }
            
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " added.");
            }
            else
            {
                //throw new Exception("Not a valid person");
                Console.WriteLine(gamer.FirstName + " Not a valid person");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " updated");
            }
            else
            {
                //throw new Exception("Not a valid person");
                //Console.WriteLine(gamer.FirstName + " Not a valid person");
            }


            
        }
    }
}
