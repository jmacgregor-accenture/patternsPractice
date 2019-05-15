using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverAtPlay.Library
{
    public class RandomIntsForDays
    {
        public List<ISubscriber> Subscribers { get;}

        public RandomIntsForDays()
        {
            var emptySubscribers = new List<ISubscriber>();

            Subscribers = emptySubscribers;
        }
        
        public int GenerateNumber()
        {
            var random = new Random();
            return random.Next();
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            Subscribers.Append(subscriber);
        }
    }
}