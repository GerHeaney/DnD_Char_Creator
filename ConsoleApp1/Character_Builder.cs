using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Character_Builder
    {
        Character_Race my_Race;
        Abilities my_Abilities;
        Character_class my_class;

        public Character_Builder()
        {
            my_Race = new Character_Race();
            my_Abilities = new Abilities();
            my_class = new Character_class();
        }


        public void randomize(Random num_gen)
        {
            my_Abilities.randomize(num_gen);
            my_Race.randomize(num_gen);
            my_class.randomize(num_gen);
        }

        public string toString()
        {
            string return_string;
            return_string = my_Race.toString();
            return_string += my_class.toString();
            return_string += my_Abilities.toString();
            return return_string;
        }
    }
}
