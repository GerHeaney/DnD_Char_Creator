using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Game_Manager
    {
        public Game_Manager()
        {

        }
        private int gold_counter,my_gold, fame_counter,my_fame, belief_counter,my_belief;

        public int Belief_counter
        {
            get
            {
                return belief_counter;
            }

            set
            {
                belief_counter = value;
            }
        }

        public int Fame_counter
        {
            get
            {
                return fame_counter;
            }

            set
            {
                fame_counter = value;
            }
        }

        public int Gold_counter
        {
            get
            {
                return gold_counter;
            }

            set
            {
                gold_counter = value;
            }
        }

        public int My_belief
        {
            get
            {
                return my_belief;
            }

            set
            {
                my_belief = value;
            }
        }

        public int My_fame
        {
            get
            {
                return my_fame;
            }

            set
            {
                my_fame = value;
            }
        }

        public int My_gold
        {
            get
            {
                return my_gold;
            }

            set
            {
                my_gold = value;
            }
        }
    }
}
