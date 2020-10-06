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
            Sweepstakes sweepstakes = new Sweepstakes("bigsweep");
            Contestant contestantOne = new Contestant();
            Contestant contestantTwo = new Contestant();
            Contestant contestantThree = new Contestant();
            sweepstakes.PrintContestantInfo(contestantOne);
            sweepstakes.PrintContestantInfo(contestantTwo);
            sweepstakes.PrintContestantInfo(contestantThree);
            sweepstakes.RegisterContestant(contestantOne);
            sweepstakes.RegisterContestant(contestantTwo);
            sweepstakes.RegisterContestant(contestantThree);
            sweepstakes.PickWinner();
            Console.ReadLine();

        }
    }
}
