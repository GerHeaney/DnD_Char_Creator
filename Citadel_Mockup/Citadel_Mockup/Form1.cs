using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void beliefTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void goldButton_Click(object sender, EventArgs e)
        {
            game_manager.My_gold += game_manager.Gold_counter;
            game_manager.Gold_counter = 0;
            this.goldTextBox.Text = game_manager.My_gold.ToString();
            
        }

        private void fameButton_Click(object sender, EventArgs e)
        {
            game_manager.My_fame += game_manager.Fame_counter;
            game_manager.Fame_counter = 0;
            this.fameTextBox.Text = game_manager.My_fame.ToString();

        }
        private void beliefButton_Click(object sender, EventArgs e)
        {
            game_manager.My_belief += game_manager.Belief_counter;
            game_manager.Belief_counter = 0;
            this.beliefTextBox.Text = game_manager.My_belief.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            game_manager.Gold_counter += 10;
            game_manager.Fame_counter += 2;
            game_manager.Belief_counter += 1;
            this.goldCounterLabel.Text = game_manager.Gold_counter.ToString();
            this.fameCounterLabel.Text = game_manager.Fame_counter.ToString();
            this.beliefCounterLabel.Text = game_manager.Belief_counter.ToString();
            
            

        }

      
    }
}
