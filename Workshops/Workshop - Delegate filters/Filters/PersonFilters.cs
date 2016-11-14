using DelegateFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFilters.Filters
{
    class PersonFilters
    {
        public static bool IsOld(Person person)
        {
            return person.Age >= 50;
        }

        public static bool IsYoung(Person person)
        {
            return person.Age < 50;
        }
    }
}
