using System;
using Observer.Pattern.Subjects;

namespace Observer.Pattern.Observers
{
    public interface IObserver
    {
        Guid Id { get; }
        string Name { get; }
        ISubject Subject { get; }

        void Update(PropertyChangeEventInformation propertyChangeEventInformation);
    }
}