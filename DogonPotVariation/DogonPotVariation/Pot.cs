using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogonPotVariation
{
    class Pot
    {
        private int diameter = 9;
        private int minimumDiameter = 1;
        private string measurementSystem = "inches";
        private int step = 1;
       
        
       
        public Pot()
        {
            Console.WriteLine("Steps to draw a Dogon-like pot:");
            DrawPot();
        }

        private void DrawPot()
        {
           

            if (diameter <= minimumDiameter)
            {
                Console.WriteLine($"{ step}. Draw the lid");
            }
            else
            {
                Console.WriteLine($"{step}. Draw a circle that is {diameter} {measurementSystem} in size");
                step++;
                diameter = 2 * (diameter/3);
            
                DrawPot(); 
            }
        } 
    }
}
    
