namespace ObserverAtPlay.Library
{
    public interface ISubscriber
    {
        void Notify(object newValue);
    }
}