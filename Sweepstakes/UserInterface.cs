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
        public static string GetManagerType()
        {
            Console.WriteLine("What type of sweepstakes manager would you like to use? stack or queue");
            string answer = Console.ReadLine();
            return answer;
        }
        public static string GetSweepstakesName()
        {
            Console.WriteLine("What would you like to call your new sweepstakes?");
            string name = Console.ReadLine();
            return name;

        }

    }
}
