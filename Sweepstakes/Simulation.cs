using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        // member variables


        // constructor
        public Simulation()
        {

        }

        //member methods
        public MarketingFirm CreateMarketingFirmWithManager()
        {
            MarketingFirm firm = new MarketingFirm(ManagerFactory(UserInterface.GetManagerType()));
            //firm.CreateSweepstakes();
            return firm;
        }
        public static ISweepstakesManager ManagerFactory(string managerType)
        {
            ISweepstakesManager sweepstakesType = null;
            switch (managerType)
            {
                case "stack":
                    sweepstakesType = new SweepstakesStackManager();
                    break;
                case "queue":
                    sweepstakesType = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("That is not a valid choice");
                    ManagerFactory(UserInterface.GetManagerType());
                    break;
            }
            return sweepstakesType;
        }
    }
}
