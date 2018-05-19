using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    interface I_Character
    {
        void get_class();
        void get_race();
        void get_abilities();

        void set_class(I_Class my_class);
        void set_race(I_Race my_race);
        void set_abilities(I_Abilities my_abilities);


    }
}
