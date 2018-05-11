using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        
       
        static void Main(string[] args)
        {

            System.Random num_gen = new Random();           
            Character_Builder my_character = new Character_Builder();
            my_character.randomize(num_gen);
            Console.Write(my_character.toString());
           
        }
    }

}
