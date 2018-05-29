using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Abilities : I_Abilities
    {
        // Character stats for determining modifiers
        int strength;
        int dexterity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;

        // Characters get to add a value to rolls based on their abilities
        int ability_modifier;

        // getters and setters
        public int Strength1
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }

        public int Dexterity1
        {
            get
            {
                return dexterity;
            }

            set
            {
                dexterity = value;
            }
        }

        public int Constitution1
        {
            get
            {
                return constitution;
            }

            set
            {
                constitution = value;
            }
        }

        public int Intelligence1
        {
            get
            {
                return intelligence;
            }

            set
            {
                intelligence = value;
            }
        }

        public int Wisdom1
        {
            get
            {
                return wisdom;
            }

            set
            {
                wisdom = value;
            }
        }

        public int Charisma1
        {
            get
            {
                return charisma;
            }

            set
            {
                charisma = value;
            }
        }
        // Ability modifiers work on the basis of each ability has a modifier of 0
        // if the ability score is 10. From there every increment or decrement of 2
        // changes the modifier by one in the positive or negative
        public int get_ablility_modifier(int ability)
        {
            ability_modifier = ability - 10;
            ability_modifier = ability_modifier / 2;
            return ability_modifier;
        }

        // generate random stats. The standard range is really 1 -18 for 
        // rolling but for now we'll just stick to 20 for an example
        public void randomize(Random num_gen)
        {
            strength        = num_gen.Next(1, 21);
            dexterity       = num_gen.Next(1, 21);
            constitution    = num_gen.Next(1, 21);
            intelligence    = num_gen.Next(1, 21);
            wisdom          = num_gen.Next(1, 21);
            charisma        = num_gen.Next(1, 21);
        }

        // for ease of debugging I always add a toString function to my code
        public string to_string()
        {
            string abilities_string = "Abilities are \n";
            abilities_string += string.Format("Strength : {0}\n",strength);
            abilities_string += string.Format("Desterity : {0}\n", dexterity);
            abilities_string += string.Format("Constitution : {0}\n", constitution);
            abilities_string += string.Format("Intelligence : {0}\n", intelligence);
            abilities_string += string.Format("Wisdom : {0}\n", wisdom);
            abilities_string += string.Format("Charisma : {0}\n", charisma);
            return abilities_string;
        }
    }
}
