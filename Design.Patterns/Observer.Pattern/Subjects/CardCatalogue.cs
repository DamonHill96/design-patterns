using System.Collections.Generic;
using Observer.Pattern.Observers;

namespace Observer.Pattern.Subjects
{
    public class CardCatalogue : ISubject
    {
        public string Name { get; }
        
        public CardCatalogue()
        {
            Observers = new List<IObserver>();
        }

        public List<IObserver> Observers { get; }
        
        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers(PropertyChangeEventInformation propertyChangeEventInformation)
        {
            foreach (var observer in Observers)
            {
                observer.Update(propertyChangeEventInformation);
            }
        }
    }
}