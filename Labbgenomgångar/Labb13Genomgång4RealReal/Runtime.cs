using Labb13Genomgång4RealReal.Filters;
using Labb13Genomgång4RealReal.Managers;
using Labb13Genomgång4RealReal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb13Genomgång4RealReal
{
    public delegate void InvalidInputMessage();

    public class Runtime
    {
        private event InvalidInputMessage InvalidInput;

        public Runtime()
        {
            InvalidInput += () =>
            {
                Console.WriteLine("Invalid input");
            };
        }

        public void Start()
        {
            PeopleManager manager = new PeopleManager();
            var loop = true;

            while (loop)
            {
                Console.Clear();
                UI.PrintMainMenu();
                var choice = Console.ReadKey(true).Key;

                switch (choice)
                {
                    case ConsoleKey.D1:
                        manager.AddPerson();
                        break;
                    case ConsoleKey.D2:
                        manager.PrintAll();
                        break;
                    case ConsoleKey.D3:
                        var filter = GetFilter();
                        Console.Clear();
                        manager.PrintWhere(filter);
                        Console.ReadKey(true);
                        break;
                    default:
                        InvalidInput.Invoke();
                        Console.ReadKey(true);
                        break;
                }
            }
        }

        private PersonFilter GetFilter()
        {
            UI.PrintFilterOptions();
            var choice = Console.ReadKey(true).Key;
            PersonFilter filter = new PersonFilter(PersonFilters.IsOld);

            switch (choice)
            {
                case ConsoleKey.D2:
                    // TODO: Add more filters
                    break;
            }

            return filter;
        }
    }
}