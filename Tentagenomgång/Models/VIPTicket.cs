using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta.Models
{
    class VIPTicket : Ticket
    {
        public int VipLevel { get; set; }

        public override string PrintInfo()
        {
            return String.Format("VIP TICKET!!!! {0}, VIP Level: {1}", base.PrintInfo(), VipLevel);
        }
    }
}
