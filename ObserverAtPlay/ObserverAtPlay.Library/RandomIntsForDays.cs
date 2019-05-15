using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverAtPlay.Library
{
    public class RandomIntsForDays
    {
        public int CurrentNumber { get; set; }
        public List<ISubscriber> Subscribers { get;}

        public RandomIntsForDays()
        {
            var emptySubscribers = new List<ISubscriber>();

            Subscribers = emptySubscribers;
        }
        
        public void GenerateNumber()
        {
            var random = new Random();
            CurrentNumber = random.Next();

            foreach (var subscriber in Subscribers)
            {
                subscriber.Notify(CurrentNumber);
            }
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber numberFan)
        {
            Subscribers.Remove(numberFan);
        }
    }
}