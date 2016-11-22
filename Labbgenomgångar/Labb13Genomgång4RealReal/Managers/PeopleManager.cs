using Labb13Genomgång4RealReal.Filters;
using Labb13Genomgång4RealReal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13Genomgång4RealReal.Managers
{
    class PeopleManager
    {
        public List<Person> People { get; set; }

        public PeopleManager()
        {
            People = new List<Person>
            {
                new Person { Name = "Steve", Age = 42 },
                new Person { Name = "Anna", Age = 83 }
            };
        }

        public void AddPerson()
        {
            var newPerson = new Person();

            Console.Write("Name: ");
            newPerson.Name = Console.ReadLine();

            Console.Write("Age: ");
            newPerson.Age = int.Parse(Console.ReadLine());

            People.Add(newPerson);
            Console.WriteLine("Person added!");
            Console.ReadKey(true);
        }

        public void PrintSingle(Person person)
        {
            Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
        }

        public void PrintAll()
        {
            foreach (var person in People)
            {
                PrintSingle(person);
            }
            Console.ReadKey(true);
        }

        public void PrintWhere(PersonFilter personFilter)
        {
            foreach (var person in People)
            {
                if (personFilter(person))
                    PrintSingle(person);
            }
        }
    }
}
