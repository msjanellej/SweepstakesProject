using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables
        Stack<Sweepstakes> stack;

        //Constructor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        //membermethods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
            //push
        {
            stack.Push(sweepstakes);
        }

        public void GetSweepstakes()
            //pop
        {
            stack.Pop();
        }
    }
}
