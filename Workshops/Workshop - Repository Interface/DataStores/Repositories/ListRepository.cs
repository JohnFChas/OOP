using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop___Repository_Interface.Models;

namespace Workshop___Repository_Interface.DataStores.Repositories
{
    class ListRepository : IRepository
    {
        public Game[] GetGames()
        {
            return MyLists.Games.ToArray();
        }

        public void AddGame(Game newGame)
        {
            MyLists.Games.Add(newGame);
        }

        public void RemoveGame(Game game)
        {
            MyLists.Games.Remove(game);
        }
    }
}
