namespace ObserverAtPlay.Library
{
    public class FanMail : IWrittenMessage
    {
        private string _greeting;
        private string _signOff;
        private string _body;

        public FanMail(string greeting, string signOff)
        {
            _greeting = greeting;
            _signOff = signOff;
        }

        public override string ToString()
        {
            return $"{_greeting}\n{_body}\n{_signOff}";
        }

        public void AddBody(string bodyMessage)
        {
            _body = bodyMessage;
        }
    }
}