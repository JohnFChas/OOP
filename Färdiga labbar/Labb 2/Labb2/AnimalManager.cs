using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class AnimalManager
    {
        // Mammals
        public List<Dog> Dogs { get; set; }
        public List<Horse> Horses { get; set; }

        // Insects
        public List<Ant> Ants { get; set; }
        public List<Mosquito> Mosquitos { get; set; }

        // Reptiles
        public List<Snake> Snakes { get; set; }
        public List<Lizard> Lizards { get; set; }

        // Birds
        public List<Eagle> Eagles { get; set; }
        public List<Crow> Crows { get; set; }

        public AnimalManager()
        {
            Dogs = new List<Dog>();
            Horses = new List<Horse>();
            Ants = new List<Ant>();
            Mosquitos = new List<Mosquito>();
            Snakes = new List<Snake>();
            Lizards = new List<Lizard>();
            Eagles = new List<Eagle>();
            Crows = new List<Crow>();
        }

        internal void ShowAnimals()
        {
            foreach (var dog in Dogs)
            {
                string hasFur = dog.HasFur ? "the dog has fur" : "the dog does not have fur";
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", dog.Name, dog.Age, dog.Weight, dog.TailLength, hasFur);
            }
            Console.ReadKey(true);
        }

        internal void RemoveAnimal()
        {
            Console.Clear();
            for (int i = 0; i < Dogs.Count; i++)
            {
                Console.WriteLine(String.Format("{0}. {1}", (i + 1), Dogs[i].Name));
            }

            var index = int.Parse(Console.ReadLine()) - 1;

            Dogs.RemoveAt(index);

            Console.WriteLine("Dog removed");
            Console.ReadKey(true);
        }

        public void AddAnimal()
        {
            Console.Clear();
            Menus.PrintAnimalTypes();

            var input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Menus.PrintMammals();

                    Dog newDog = new Dog();
                    Console.Write("Name: ");
                    newDog.Name = Console.ReadLine();

                    Console.Write("Age: ");
                    newDog.Age = int.Parse(Console.ReadLine());

                    Console.Write("Weight: ");
                    newDog.Weight = int.Parse(Console.ReadLine());

                    Console.Write("Tail length: ");
                    newDog.TailLength = int.Parse(Console.ReadLine());

                    Dogs.Add(newDog);

                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Menus.PrintInsects();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    Menus.PrintReptiles();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.Clear();
                    Menus.PrintBirds();
                    break;
            }
        }
    }
}
