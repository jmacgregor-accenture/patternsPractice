using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ObserverAtPlay.Library
{
    public class NumberFan : ISubscriber
    {
        public int FavoriteNumber { get; set; }
        public ISubject Subscription { get; set; }

        public void Notify(object newValue)
        {
            FavoriteNumber = (int) newValue;
        }


        public void SubscribeTo(ISubject subject)
        {
            subject.AddSubscriber(this);
            Subscription = subject;
        }

        public void Unsubscribe(ISubject subject)
        {
            subject.RemoveSubscriber(this);
            Subscription = null;
        }
    }
}