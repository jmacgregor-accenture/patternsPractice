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
            var mail = new FanMail(greeting);
            
            mail.ToString().ShouldContain(greeting);
        }
    }
}