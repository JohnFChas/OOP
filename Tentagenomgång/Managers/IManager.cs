using OOPTenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta.Managers
{
    interface IManager
    {
        List<Customer> Customers { get; set; }
        List<Ticket> Tickets { get; set; }

        void AddCustomer();
        void BookTicket();
        void Filter();
    }
}
