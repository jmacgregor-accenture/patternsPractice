using System;
using System.Collections;
using System.Collections.Generic;

namespace ObserverAtPlay.Library
{
    public class RandomIntsForDays
    {
        public IEnumerable<ISubscriber> Subscribers { get;}

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
    }
}