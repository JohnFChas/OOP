using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserObjekt
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person()
        {
        }

        public Person(string name, int age, string city)
        {
            // PascalCasing: MyVariableName
            // camelCasing: myVariableName
            Name = name;
            Age = age;
            City = city;
        }

        public string Introduction()
        {
            return String.Format("Hej! Jag heter {0} och jag är {1} år gammal. Jag bor i {2}",
                                 Name, Age, City);
        }
    }
}