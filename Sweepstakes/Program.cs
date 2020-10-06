using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant contestantOne = new Contestant();
            Contestant contestantTwo = new Contestant();
            Contestant contestantThree = new Contestant();
            Simulation simulation = new Simulation();
            simulation.CreateMarketingFirmWithManager();
            Sweepstakes.RegisterContestant(contestantOne);
            Console.ReadLine();

        }
    }
}
