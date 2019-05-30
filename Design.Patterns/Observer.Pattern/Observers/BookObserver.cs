using System;
using Observer.Pattern.Subjects;

namespace Observer.Pattern.Observers
{
    public class BookObserver : IObserver
    {
        public BookObserver(string name, ISubject subject)
        {
            Name = name;
            Subject = subject;
            subject.RegisterObserver(this);
        }

        public Guid Id { get; }
        public string Name { get; private set; }
        public ISubject Subject { get; }
        
        public void Update(PropertyChangeEventInformation propertyChangeEventInformation)
        {
            Name = propertyChangeEventInformation.Name;
        }
    }
}