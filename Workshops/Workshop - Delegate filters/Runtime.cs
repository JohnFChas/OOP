using DelegateFilters.Filters;
using DelegateFilters.Managers;
using DelegateFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateFilters.Delegates;

namespace DelegateFilters
{
    class Runtime
    {
        public void Start()
        {
            PersonManager manager = new PersonManager();

            manager.PrintWhere(PersonFilters.IsOld);
            manager.PrintWhere(PersonFilters.IsYoung);

            PersonFilter filter = delegate (Person person)
            {
                return true;
            };

            manager.PrintWhere(person => person.Age == 32);
        }
    }
}
