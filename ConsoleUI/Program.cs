using DemoLibrary;
using System;

// DIP stands for "Dependency Inversion Principle" design pattern
// DIP states that high-level modules should not depend on low-level modules
// But rather both should depend on abstractions and those abstractions
// should not depend on details.
// Dependency Inversion is the principle and Dependency Injection is one of the ways
// (the most common way) where you make the principle work
namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Iyad";
            owner.LastName = "Shobaki";
            owner.EmailAddress = "I@Shobaki.com";
            owner.PhoneNumber = "555-1212";


            IChore chore = Factory.CreateChore();

            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;
            

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
