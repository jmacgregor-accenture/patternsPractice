using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ObserverAtPlay.Library
{
    public class NumberFan : ISubscriber
    {
        public int FavoriteNumber { get; set; }
        
        public void Notify(object newValue)
        {
            FavoriteNumber = (int) newValue;
        }

        
    }
}