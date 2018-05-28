using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Attributes
{
    class Attribute : Base_Attribute
    {
        private List<Raw_Bonus> raw_bonuses;
        private List<Final_Bonus> final_bonuses;

        protected int final_value;
        public Attribute(int added_value, int added_multiplier) : base(added_value, added_multiplier)
        {
            raw_bonuses = new List<Raw_Bonus>();
            final_bonuses = new List<Final_Bonus>();
        }

        public void add_raw_bonus(Raw_Bonus bonus)
        {
            raw_bonuses.Add(bonus);
        }
        public void remove_raw_bonus(Raw_Bonus bonus)
        {
            if (raw_bonuses.Contains(bonus)){
                raw_bonuses.Remove(bonus);
            }
           
        }
        public void add_final_bonus(Final_Bonus bonus)
        {
            final_bonuses.Add(bonus);
        }
        public void remove_final_bonus(Final_Bonus bonus)
        {
            if (final_bonuses.Contains(bonus)){
                final_bonuses.Remove(bonus);
            }
        }

        protected void apply_raw_bonuses()
        {
            int raw_bonus_value =0;
            int raw_bonus_multiplier=0;

            foreach (var bonus in raw_bonuses)
            {
                raw_bonus_value += bonus.Base_value;
                raw_bonus_multiplier += bonus.Base_value;

            }
            final_value += raw_bonus_value;
            final_value *= (1 + raw_bonus_multiplier);

        }

        protected void apply_final_bonuses()
        {
            int final_bonus_value=0;
            int final_bonus_multiplier=0;


            foreach (var bonus in final_bonuses)
            {
                final_bonus_value += bonus.Base_value;
                final_bonus_multiplier += bonus.Base_value;

            }
            final_value += final_bonus_value;
            final_value *= (1 + final_bonus_multiplier);
        }

        public virtual int calculate_attribute_value()
        {
            final_value = Base_value;
         
            apply_raw_bonuses();
            apply_final_bonuses();
            return final_value;
        }
        public int get_final_Value()
        {
            return calculate_attribute_value();
        }
    }
}