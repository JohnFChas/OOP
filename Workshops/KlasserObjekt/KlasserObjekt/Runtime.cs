using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserObjekt
{
    class Runtime
    {
        public void Start()
        {
            // The keyword "new" is used to instantiate classes
            // This creates an object

            #region Old stuff
            //Person person1 = new Person
            //{
            //    Name = "John",
            //    Age = 10,
            //    City = "Stockholm"
            //};

            //Person person2 = new Person
            //{
            //    Name = "Anna",
            //    Age = 12,
            //    City = "Göteborg"
            //};

            //Person person3 = new Person("Kim", 29, "Malmö");

            //Console.WriteLine(person1.Name);
            //Console.WriteLine(person2.Name);
            //Console.WriteLine(person3.Name);
            #endregion

            #region More old stuff
            //List<Person> people = new List<Person>()
            //{
            //    new Person { Name = "John", Age = 500, City = "Stockholm" },
            //    new Person { Name = "Anna", Age = 28, City = "Göteborg" },
            //    new Person { Name = "Råger", Age = 37, City = "Malmö" },
            //    new Person { Name = "Kim", Age = 23, City = "Skåne" }
            //};

            //people.Add(new Person { Name = "Robin", Age = 42, City = "Luleå" });

            //foreach (var person in people)
            //{
            //    // Old fasion concatination
            //    //Console.WriteLine("Hej! Jag heter " + person.Name + " och jag är " + person.Age + " år gammal.");

            //    Console.WriteLine(person.Introduction());
            //}
            #endregion

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("City: ");
            string city = Console.ReadLine();

            Person newPerson = new Person
            {
                Name = name,
                Age = age,
                City = city
            };

            bool loop = false;
            do
            {
                loop = false;
                Console.WriteLine("Would you like to introduce yourself? (y/n)");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine(newPerson.Introduction());
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("Okay bye");
                        break;
                    default:
                        loop = true;
                        break;
                }
            } while (loop);
        }
    }
}
