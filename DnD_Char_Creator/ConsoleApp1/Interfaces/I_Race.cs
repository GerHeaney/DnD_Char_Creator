using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    interface I_Race
    {
        void set_traits();
        string to_string();
        void randomize(Random rand);
    }
}
