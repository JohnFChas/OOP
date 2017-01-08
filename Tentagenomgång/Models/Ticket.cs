using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta.Models
{
    class Ticket
    {
        public Customer Buyer { get; set; }
        public float Price { get; set; }

        public virtual string PrintInfo()
        {
            return String.Format("Buyer: {0}, Price: {1}", Buyer.Name, Price);
        }
    }
}
