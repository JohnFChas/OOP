using Labb13Genomgång4RealReal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13Genomgång4RealReal.Filters
{
    public delegate bool PersonFilter(Person person);

    class PersonFilters
    {
        // The methods we're about to use with the delegate has to match
        // the return type and input arguments of the delegate itself.
        public static bool IsOld(Person person)
        {
            return person.Age > 80;
        }
    }
}
