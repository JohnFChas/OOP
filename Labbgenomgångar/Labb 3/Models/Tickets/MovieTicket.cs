﻿using Labb3.Models.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3.Models.Tickets
{
    class MovieTicket : Ticket
    {
        public Movie Movie { get; set; }
    }
}
