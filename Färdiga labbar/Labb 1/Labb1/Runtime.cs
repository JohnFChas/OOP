using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Runtime
    {
        public void Start()
        {
            #region Del 1
            //Dog dog1 = new Dog
            //{
            //    Name = "Dogge",
            //    Age = 12,
            //    Breed = "Labb"
            //};

            //Dog dog2 = new Dog
            //{
            //    Name = "Spike",
            //    Age = 3,
            //    Breed = "Stor hund"
            //};

            //Dog dog3 = new Dog
            //{
            //    Name = "Fido",
            //    Age = 2,
            //    Breed = "Liten hund"
            //};

            //Console.WriteLine("Name: {0}, Age: {1}, Breed: {2}", dog1.Name, dog1.Age, dog1.Breed);
            //Console.WriteLine("Name: {0}, Age: {1}, Breed: {2}", dog2.Name, dog2.Age, dog2.Breed);
            //Console.WriteLine("Name: {0}, Age: {1}, Breed: {2}", dog3.Name, dog3.Age, dog3.Breed);
            #endregion

            #region Del 2 och 3
            DogManager dogManager = new DogManager();

            bool loop = true;

            while (loop)
            {
                Menu.PrintMainMenu();

                Console.Write("Choice: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        dogManager.AddDog();
                        break;

                    case 2:
                        dogManager.RemoveDog();
                        break;

                    case 3:
                        dogManager.PrintDogs();
                        break;
                    case 4:
                        loop = false;
                        break;
                }

                Console.WriteLine("Bye bye");
            }
            #endregion
        }
    }
}
