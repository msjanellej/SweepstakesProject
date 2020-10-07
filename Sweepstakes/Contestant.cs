using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant : INotifiable
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;
        public bool isWinner;
        public Contestant()
        {
            firstName = UserInterface.GetContestantInfo("firstName");
            lastName = UserInterface.GetContestantInfo("lastName");
            emailAddress = UserInterface.GetContestantInfo("emailAddress");
            Random rand = new Random();
            registrationNumber = rand.Next(1, 50);
            isWinner = false;
        }
        public void Notify(INotifiable notified)
        {
            if (isWinner)
            {
                Console.WriteLine(firstName + ", Congratulations!! You have won!!");
            }
            else
            {
                Console.WriteLine(firstName + ", Better Luck Next Time!!");
            }
        }
       
    }
}
