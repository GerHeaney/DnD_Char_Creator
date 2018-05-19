using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1
{
    class Character : I_Character
    {
        I_Race my_Race;
        I_Abilities my_Abilities;
        I_Class my_class;

        public Character( I_Race passed_race, I_Abilities passed_abilities, I_Class passed_class){
            my_Race = passed_race;
            my_Abilities = passed_abilities;
            my_class = passed_class;
            }
        public void get_abilities()
        {
            throw new NotImplementedException();
        }

        public void get_class()
        {
            throw new NotImplementedException();
        }

        public void get_race()
        {
            throw new NotImplementedException();
        }

      
        public void set_class(I_Class my_class)
        {
            this.my_class = my_class;
        }

        public void set_race(I_Race my_race)
        {
            this.my_Race = my_race;
        }

        public void set_abilities(I_Abilities my_abilities)
        {
            this.my_Abilities = my_abilities;
        }
    }
}
