using ConsoleApp1.Character;
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Character_Builder
    {
        I_Character game_character;
        Character_Race my_Race;
        Abilities my_Abilities;
        I_Class my_class;

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
            return_string = my_Race.to_string();
            return_string += my_class.to_string();
            return_string += my_Abilities.toString();
            return return_string;
        }

        public I_Character build_character()
        {
            return game_character;
        }
    }
}
