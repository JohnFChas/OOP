using OOPTenta.Managers;
using OOPTenta.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta
{
    class Runtime
    {
        internal void Start()
        {
            var manager = new Manager();

            var loop = true;

            while (loop)
            {
                Console.Clear();
                Menus.PrintMainMenu();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        manager.AddCustomer();
                        break;

                    case ConsoleKey.D2:
                        manager.BookTicket();
                        break;

                    case ConsoleKey.D3:
                        manager.SearchCustomer();
                        break;

                    case ConsoleKey.D4:
                        manager.Filter();
                        break;

                    case ConsoleKey.D5:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                if (loop)
                    Console.ReadKey(true);
            }
        }
    }
}
