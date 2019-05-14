using System;

namespace ObserverAtPlay.Library
{
    public class RandomIntsForDays
    {
        public int GenerateNumber()
        {
            var random = new Random();
            return random.Next();
        }
    }
}