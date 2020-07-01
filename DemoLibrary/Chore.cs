using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    // Chore is high-level depend on Logger and Emailer
    // If we made change to Logger will break the Chore and will break Program.cs
    public class Chore
    {
        public string ChoreName { get; set; }
        public Person Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            Logger log = new Logger();
            log.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            Logger log = new Logger();
            log.Log($"Competed { ChoreName }");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}
