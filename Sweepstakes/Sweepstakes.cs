using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        public Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count, contestant);
        }
        public Contestant PickWinner() 
        {
            Contestant winner;
            Random rand  = new Random();
            int winningIntegar = rand.Next(contestants.Count);
            winner = contestants[winningIntegar];
            winner.isWinner = true;
            Email.SendEmail(winner);
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("First Name: " + contestant.firstName);
            Console.WriteLine("Last Name: " + contestant.lastName );
            Console.WriteLine("Email Address: " + contestant.emailAddress);
            Console.WriteLine("Registration Number: " + contestant.registrationNumber);
        }
        public void NotifyAllContestants(Contestant winner)
        {
            foreach  (KeyValuePair<int, Contestant> contestant in contestants )
            {
                contestant.Value.Notify(winner);

            }
        }
    }
}
