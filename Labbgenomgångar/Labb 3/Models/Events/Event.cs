using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3.Models.Events
{
    abstract class Event
    {
        public enum EventType
        {
            Movie,
            Concert
        };

        public string Name { get; set; }
        public DateTime Start { get; set; }
        public EventType Type { get; set; }

        public virtual string GetEventInfo()
        {
            return String.Format("Name: {0}", Name);
        }
    }
}
