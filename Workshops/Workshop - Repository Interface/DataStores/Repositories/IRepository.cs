using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop___Repository_Interface.Models;

namespace Workshop___Repository_Interface.DataStores.Repositories
{
    interface IRepository
    {
        Game[] GetGames();
        void AddGame(Game newGame);
        void RemoveGame(Game game);
    }
}
