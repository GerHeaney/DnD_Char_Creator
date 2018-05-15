using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    interface I_Abilities
    {
        int Strength1 { get; set; }
        int Dexterity1 { get; set; }
        int Constitution1 { get; set; }
        int Intelligence1 { get; set; }
        int Wisdom1 { get; set; }
        int Charisma1 { get; set; }
        string to_string();
        void randomize(Random rand);
    }
}
