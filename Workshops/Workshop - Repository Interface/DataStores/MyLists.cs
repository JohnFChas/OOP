using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop___Repository_Interface.Models;

namespace Workshop___Repository_Interface.DataStores
{
    class MyLists
    {
        private static List<Game> games;

        public static List<Game> Games
        {
            get
            {
                if (games == null)
                    games = new List<Game>();

                return games;
            }
        }
    }
}
