using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        //member variables



        //member methods
       public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine("Please enter your " + prompt);
            string input = Console.ReadLine();
            return input;
        }
    }
}
