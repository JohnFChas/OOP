using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3.Models.Events
{
    class Movie : Event
    {
        public float Length { get; set; }

        public override string GetEventInfo()
        {
            string eventInfo = base.GetEventInfo();
            return String.Format("{0}, length: {1}", eventInfo, Length);
        }
    }
}
