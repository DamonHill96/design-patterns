using System;
using Strategy.Pattern.Models;

namespace Strategy.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Item bookToReturn = new Book(Guid.NewGuid(), "Book of the ages");
            Item journalToReturn = new Journal(Guid.NewGuid(), "Boring science journal");

           
            journalToReturn.Checkout();

            Console.WriteLine($"Your {bookToReturn.GetType().Name} was {bookToReturn.Checkout()}");
            Console.WriteLine($"Your {journalToReturn.GetType().Name} was {journalToReturn.Checkout()}");
        }
    }
}