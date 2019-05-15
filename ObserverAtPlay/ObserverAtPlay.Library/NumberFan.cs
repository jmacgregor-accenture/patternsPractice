using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ObserverAtPlay.Library
{
    public class NumberFan : ISubscriber
    {
        public int FavoriteNumber { get; set; }
        public ISubject Subscription { get; set; }
        public IWrittenMessage Letter { get; }

        public NumberFan()
        {
            Letter = new FanMail("Hi", "Bye");
        }
        
        public NumberFan(IWrittenMessage letter)
        {
            Letter = letter;
        }

        public void Notify(object newValue)
        {
            FavoriteNumber = (int) newValue;
            Letter.AddBody($"My new Favorite Number Is {FavoriteNumber}!!!");
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