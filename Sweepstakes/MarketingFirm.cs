using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            manager = sweepstakesManager; 
        }
        //I used dependency injection of the sweepstakes manager into the marketing firm because it gives the marketing firm the ability to 
        //implement either of the sweepstakes Managers (stack or queue). This gives additional flexiblity to the end user to allow them to pick
        // the type of marketing manager they want to implement without having to write additional logic to support each one. It also works with
        // the open/closed principle of SOLID, because if additional sweepstakes managers are added in the future we won't have to rework logic in 
        // order to add a different type of data structure (ie: list, dictionary, etc).
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetSweepstakesName());
        }
    }
}
