using System;
using System.Collections;
using System.Collections.Generic;

namespace ObserverAtPlay.Library
{
    public class RandomIntsForDays
    {
        public IEnumerable<ISubscriber> Subscribers { get; set; } = new List<ISubscriber>();
        
        public int GenerateNumber()
        {
            var random = new Random();
            return random.Next();
        }
    }
}