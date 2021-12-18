/*
 * /Madeline Rogers with help from Elias Olson
 * Recursion Assignment
 * 9/29/2021
 * Based on Dogon Pot pseudo code from the book
 * African Fractals: Modern Computing and Indigenous Design by Ron Eglash
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogonPotVariation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Example steps to draw a Dogon-like pot.";
            new Pot();
            Console.ReadKey();

        }
    }
}
