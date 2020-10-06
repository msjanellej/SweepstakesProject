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
        string firstName;
        string lastName;
        string emailAddress;
        string registrationNumber;


        //constructor
        public Contestant(string firstName, string lastName, string emailAddress, string registrationNumber)
        {
            this.firstName = firstName; //like this
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;

        }


        //member methods
    }
}
