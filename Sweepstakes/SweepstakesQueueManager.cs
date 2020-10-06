using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager: ISweepstakesManager
    {
        //member variables
        Queue<Sweepstakes> queue;

        //Constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
            //enqueue
        {
            queue.Enqueue(sweepstakes);

        }
        public void GetSweepstakes()
            //dequeue
        {
            queue.Dequeue();
        }
    }
}
