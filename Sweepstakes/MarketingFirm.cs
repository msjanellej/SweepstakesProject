using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        // member variables
        ISweepstakesManager manager;

        //constructor
        public MarketingFirm()
        {
            manager = new ISweepstakesManager();
        }


        //member methods
        public void CreateSweepstakes()
        {

        }
    }
}
