using OOPTenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta.Filters
{
    delegate bool TicketFilter(Ticket ticket);

    class TicketFilters
    {
        public static bool IsPremiumDeluxe(Ticket ticket)
        {
            return ticket.Price >= 500;
        }

        public static bool IsMinVipLevel(Ticket ticket)
        {
            return true;
        }
    }
}
