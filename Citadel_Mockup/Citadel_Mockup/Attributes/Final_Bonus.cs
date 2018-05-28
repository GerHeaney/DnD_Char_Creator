using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsFormsApp1.Attributes
{
    class Final_Bonus : Base_Attribute
    {
        private Timer my_timer;
        private Attribute my_parent;
        public Final_Bonus(int time,int added_value, int added_multiplier) : base(added_value, added_multiplier)
        {
            my_timer = new Timer(time);
            my_timer.Elapsed += on_timer_end;
        }
        public void start_tmer(Attribute parent)
        {
            my_parent = parent;

            my_timer.Start();
        }

        private void on_timer_end(object sender, ElapsedEventArgs e)
        {
            my_timer.Stop();
            my_parent.remove_final_bonus(this);
        }
    }
}
