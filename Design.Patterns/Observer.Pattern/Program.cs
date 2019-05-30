using System;
using Observer.Pattern.Observers;
using Observer.Pattern.Subjects;

namespace Observer.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new CardCatalogue();
            var observer = new BookObserver("default name", subject);

            Console.WriteLine(observer.Name);
            subject.NotifyObservers(new PropertyChangeEventInformation("new name"));
            Console.WriteLine(observer.Name);
        }
    }
}