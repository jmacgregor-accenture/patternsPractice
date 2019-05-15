using ObserverAtPlay.Library;
using Shouldly;
using Xunit;

namespace ObserverAtPlay.Tests
{
    public class FanMailShould
    {
        [Fact]
        public void HaveBoilerPlateGreeting()
        {
            var greeting = "Hey Number Peeps! Checkout this great new number I found!";
            var mail = new FanMail(greeting, "Bye");
            
            mail.ToString().ShouldContain(greeting);
        }

        [Fact]
        public void HaveBoilerPlateSignOff()
        {
            var signOff = "Till I find my next number, go forth and spread the word of the integer!";
            var mail = new FanMail("Hi", signOff);
            
            mail.ToString().ShouldContain(signOff);
        }

        [Fact]
        public void ChangeMessageBody()
        {
            var mail = new FanMail("Hi", "Bye");
            var bodyTest = "This is a Body Message!";

            mail.AddBody(bodyTest);
            
            mail.ToString().ShouldContain(bodyTest);
        }
    }
}