using DelegatesWorkshop.Filters;
using DelegatesWorkshop.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWorkshop
{
    class Runtime
    {
        public void Start()
        {
            PersonManager manager = new PersonManager();

            PersonFilter isOldFilter = PersonFilters.IsOld;
            PersonFilter isYoungFilter = PersonFilters.IsYoung;
            PersonFilter nameStartsWithAFilter = PersonFilters.NameStartsWithA;

            Console.WriteLine("Old people:");
            manager.PrintWhere(isOldFilter);

            Console.WriteLine("\nYoung people:");
            manager.PrintWhere(isYoungFilter);

            Console.WriteLine("\nPeople whose name starts with A:");
            manager.PrintWhere(nameStartsWithAFilter);

            Console.WriteLine("\nPeople with names longer than 4 letters:");
            manager.PrintWhere(person => person.Name.Length > 4);
        }
    }
}
