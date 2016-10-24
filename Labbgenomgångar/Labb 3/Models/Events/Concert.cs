using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3.Models.Events
{
    class Concert : Event
    {
        public string Artist { get; set; }

        public override string GetEventInfo()
        {
            var eventInfo = base.GetEventInfo();
            return String.Format("{0}, artist playing: {1}", 
                eventInfo, 
                Artist);
        }
    }
}
