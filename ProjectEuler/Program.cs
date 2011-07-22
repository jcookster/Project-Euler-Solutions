using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ProjectEuler.Interfaces;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler");
            Console.WriteLine("------------------------------------------------------");
           
            // Kick off the Problem sets.
            Euler.Run();

            // Keep running so the console doesn't immediately shut. 
            // There has to be a better way to do this...
            while (true){ }
        }
    }
}
