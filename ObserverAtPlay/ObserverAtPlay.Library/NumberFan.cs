namespace ObserverAtPlay.Library
{
    public class NumberFan : ISubscriber
    {
        public int FavoriteNumber { get; set; }
        
        public void Notify(object newValue)
        {
            
        }

        
    }
}