using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // For a simple example i'll use strings just as dummies for the classes i'd create
    // Each race has ability modifiers to add to their scores. They also get some traits and
    // skill proficiencies
    class Character_Race
    {
        string[] races = { "Human", "Dwarf", "Elf", "Half-Orc", "Gnome", "Halfling", "Tiefling", "Dragonborn" };
        string my_race;

        public string My_race
        {
            get
            {
                return my_race;
            }

            set
            {
                my_race = value;
            }
        }

        public void randomize(Random rand_num)
        {
            my_race = races[rand_num.Next(0, races.Length)];
        }

        // Will update this further as needed
        public string toString()
        {
            string return_string = string.Format("Character race is {0}\n", my_race);
            return return_string;
        }
    }
}
