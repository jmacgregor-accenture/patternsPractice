namespace ObserverAtPlay.Library
{
    public interface ISubject
    {
        void AddSubscriber(ISubscriber subscriber);
        void RemoveSubscriber(ISubscriber subscriber);
    }
    
}