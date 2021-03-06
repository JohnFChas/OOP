﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop___Repository_Interface.DataStores.Repositories;
using Workshop___Repository_Interface.Models;

namespace Workshop___Repository_Interface.Controllers
{
    class GamesController
    {
        private IRepository repository = new ListRepository();

        public void CreateGame()
        {
            var newGame = UI.CreateGame();
            repository.AddGame(newGame);
        }

        public void RemoveGame()
        {
            var games = repository.GetGames();
            var index = UI.SelectGame(games) - 1;
            repository.RemoveGame(games[index]);
        }

        public void EditGame()
        {
            var games = repository.GetGames();
            UI.PrintGameList(games);
            int index = UI.SelectGame(games) - 1;

            UI.EditGame(games[index]);
        }

        public void PrintGameList()
        {
            Console.Clear();
            UI.PrintGameList(repository.GetGames());
            Console.ReadKey(true);
        }
    }
}
