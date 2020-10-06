using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;


        //constructor
        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor("firstName");
            lastName = UserInterface.GetUserInputFor("lastName");
            emailAddress = UserInterface.GetUserInputFor("emailAddress");
            Random rand = new Random();
            registrationNumber = rand.Next(1,50);

        }


        //member methods
    }
}
