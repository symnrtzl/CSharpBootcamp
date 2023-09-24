using GameSalesDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesDemo.Abstract
{
    public interface IGameService
    {
        void Add(Game game);

        void Update(Game game);

        void Delete(Game game);
    }
}
