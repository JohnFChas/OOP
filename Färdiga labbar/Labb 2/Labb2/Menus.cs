using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Menus
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("1. Add animal");
            Console.WriteLine("2. Remove animal");
            Console.WriteLine("3. Show animal(s)");
            Console.WriteLine("4. Exit");
        }

        public static void PrintAnimalTypes()
        {
            Console.WriteLine("1. Mammal");
            Console.WriteLine("2. Insects");
            Console.WriteLine("3. Reptiles");
            Console.WriteLine("4. Birds");
        }

        public static void PrintMammals()
        {
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Horse");
        }

        public static void PrintInsects()
        {
            Console.WriteLine("1. Ant");
            Console.WriteLine("2. Mosquito");
        }

        public static void PrintReptiles()
        {
            Console.WriteLine("1. Snake");
            Console.WriteLine("2. Lizard");
        }

        public static void PrintBirds()
        {
            Console.WriteLine("1. Eagle");
            Console.WriteLine("2. Crow");
        }
    }
}
