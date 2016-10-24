using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop___Repository_Interface.Models
{
    class Game
    {
        public enum GenreType
        {
            Action = 1,
            Roleplaying,
            Adventure,
            Strategy,
            Racing
        }

        public string Name { get; set; }
        public GenreType Genre { get; set; }
    }
}
