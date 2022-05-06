using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public abstract class EntityBasicStats
    {
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Magic { get; set; }
        public int Smarts { get; set; }
    }
}
