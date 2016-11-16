using JsonWorkshop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonWorkshop
{
    public class Runtime
    {
        public void Start()
        {
            var directory = Environment.CurrentDirectory;
            var file = String.Format("{0}{1}", directory, "\\data.json");

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (!File.Exists(file))
                File.Create(file);

            #region Single object
            //Person myPerson = new Person { Id = 1, Name = "Steve", Age = 32 };

            //string jsonString = JsonConvert.SerializeObject(myPerson);

            //File.WriteAllText(file, jsonString);
            #endregion

            Person[] myArray = new Person[]
            {
                new Person { Id = 1, Name = "Steve", Age = 32 },
                new Person { Id = 2, Name = "Alice", Age = 57 },
                new Person { Id = 3, Name = "Anna", Age = 21 }
            };

            // Serializes the object/array, meaning the object is converted
            // to a formatted text string.
            string jsonString = JsonConvert.SerializeObject(myArray);

            // Writes the JSON-formatted text to a file.
            File.WriteAllText(file, jsonString);

            string jsonFromFile = File.ReadAllText(file);

            // Deserializes the formatted string (from the file) to a Person-array
            Person[] myDeserializedArray = JsonConvert.DeserializeObject<Person[]>(jsonFromFile);

            foreach (var person in myDeserializedArray)
            {
                Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            }
        }
    }
}