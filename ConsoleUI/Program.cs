using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DIP stands for "Dependency Inversion Principle" design pattern
// DIP states that high-level modules should not depend on low-level modules
// But rather both should depend on abstractions and those abstractions
// should not depend on details.
namespace ConsoleUI
{
    class Program
    {
        // Main is high-level depend on Person and Chore
        // If we made changes to Chore will break Program.cs
        static void Main(string[] args) 
        {
            Person owner = new Person
            {
                FirstName = "Iyad",
                LastName = "Shobaki",
                EmailAddress = "I@Shobaki.com",
                PhoneNumber = "555-1212"
            };

            Chore chore = new Chore
            {
                ChoreName = "Take out the trash",
                Owner = owner
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
