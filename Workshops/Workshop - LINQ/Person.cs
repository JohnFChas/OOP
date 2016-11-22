using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop___LINQ
{
    class Person
    {
        public enum MyEnum
        {
            Action = 1,
            Romance,
            Comedy
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public MyEnum MyProp { get; set; }

        public void Test()
        {
            MyProp = MyEnum.Action;

            int input = 1;

            bool compare = MyProp == (MyEnum)input;

            Console.WriteLine("{0}: {1}", MyProp.ToString(), "Movie name");
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
