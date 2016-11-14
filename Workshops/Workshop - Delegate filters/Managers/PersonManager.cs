using DelegateFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateFilters.Delegates;

namespace DelegateFilters.Managers
{
    class PersonManager
    {
        public List<Person> People { get; set; }

        public PersonManager()
        {
            People = new List<Person>
            {
                new Person { Name = "Frank", Age = 40 },
                new Person { Name = "Anna", Age = 65 },
                new Person { Name = "Steve", Age = 32 },
                new Person { Name = "Gunhild", Age = 80 }
            };
        }

        public void PrintWhere(PersonFilter filter)
        {
            foreach (var person in People)
            {
                if (filter(person))
                    Console.WriteLine(person.Name);
            }
        }
    }
}
