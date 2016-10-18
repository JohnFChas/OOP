using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class DogManager
    {
        public List<Dog> Dogs { get; set; }

        public DogManager()
        {
            Dogs = new List<Dog>()
            {
                new Dog { Name = "Dogge", Age = 12, Breed = "Labb" },
                new Dog { Name = "Spike", Age = 3, Breed = "Stor" },
                new Dog { Name = "Fido", Age = 2, Breed = "Liten" }
            };
        }

        public void AddDog()
        {
            Dog newDog = new Dog();

            Console.Write("Name: ");
            newDog.Name = Console.ReadLine();

            Console.Write("Age: ");
            newDog.Age = int.Parse(Console.ReadLine());

            Console.Write("Breed: ");
            newDog.Breed = Console.ReadLine();

            Dogs.Add(newDog);
        }

        public void RemoveDog()
        {
            for (int i = 1; i <= Dogs.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, Dogs[i - 1].Name);
            }

            Console.Write("Choice: ");
            int index = int.Parse(Console.ReadLine());

            Dogs.RemoveAt(index - 1);
        }

        public void PrintDogs()
        {
            foreach (var dog in Dogs)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Breed: {2}",
                                  dog.Name,
                                  dog.Age,
                                  dog.Breed);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
