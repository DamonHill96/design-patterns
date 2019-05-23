using System.Collections.Generic;
using Observer.Pattern.Observers;

namespace Observer.Pattern.Subjects
{
    public interface ISubject
    {
        string Name { get; }
        List<IObserver> Observers { get; }
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(PropertyChangeEventInformation propertyChangeEventInformation);
    }
}