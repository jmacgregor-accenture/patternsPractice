namespace ObserverAtPlay.Library
{
    public class FanMail
    {
        private string _greeting;

        public FanMail(string greeting)
        {
            _greeting = greeting;
        }

        public override string ToString()
        {
            return _greeting;
        }
    }
}