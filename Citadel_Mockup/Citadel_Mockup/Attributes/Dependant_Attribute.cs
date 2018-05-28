using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Attributes
{
     class DependantAttribute : Attribute
    {
        protected  List<Attribute> other_attributes;
        public DependantAttribute(int added_value, int added_multiplier) : base(added_value, added_multiplier)
        {
            other_attributes = new List<Attribute>();
        }

        public void addAttribute(Attribute attribute_to_add)
        {
            other_attributes.Add(attribute_to_add);
        }
        public  void removeAttribute(Attribute attribute_to_add)
        {
            if (other_attributes.Contains(attribute_to_add) )
            {
                other_attributes.Remove(attribute_to_add);
            }
        }
         
        public override int calculate_attribute_value()
        {
            // Specific attribute code goes somewhere in here
             
            final_value = Base_value;
            
            apply_raw_bonuses();

            apply_final_bonuses();
             
            return final_value;
        }
    }
}

