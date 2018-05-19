using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Character_class : I_Class
    {
        string[] classes = { "Barbarian", "Bard", "Cleric", "Fighter", "Monk", "Paladin", "Ranger", "Rogue",
                            "Sorcerer","Warlock","Wizard"};
        private string my_class;
        private int health;
        private Skills_enum[] my_skills;
        public string My_class
        {
            get
            {
                return my_class;
            }

            set
            {
                my_class = value;
            }
        }

        public void set_skills()
        {
            throw new NotImplementedException();
        }

        public void randomize(Random rand_num)
        {
            my_class = classes[rand_num.Next(0, classes.Length)];
        }

        public void set_health()
        {
            throw new NotImplementedException();
        }

        public void set_proficiencies()
        {
            throw new NotImplementedException();
        }

        // Will update this further as needed
        public string to_string()
        {
            string return_string = string.Format("Character class is {0}\n", my_class);
            return return_string;
        }
    }
}
