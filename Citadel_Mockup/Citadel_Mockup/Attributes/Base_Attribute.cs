using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Attributes
{
    class Base_Attribute
    {
        private int base_value;
        private int base_multiplier;

        public Base_Attribute(int added_value, int added_multiplier =0)
        {
            base_value = added_value;
            base_multiplier = added_multiplier;
        }

        public int Base_value
        {
            get
            {
                return base_value;
            }

            set
            {
                base_value = value;
            }
        }

        public int Base_multiplier
        {
            get
            {
                return base_multiplier;
            }

            set
            {
                base_multiplier = value;
            }
        }
    }
}
