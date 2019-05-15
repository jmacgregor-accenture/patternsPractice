using System.Linq;
using ObserverAtPlay.Library;
using Shouldly;
using Xunit;

namespace ObserverAtPlay.Tests
{
    public class RandomNumberGeneratorShould
    {
        [Fact]
        public void GenerateNumbers()
        {
            var subject = new RandomIntsForDays();

            subject.GenerateNumber();
            var result = subject.CurrentNumber;

            result.ShouldBeOfType<int>();
        }

        [Fact]
        public void GenerateNewNumberEachTime()
        {
            var subject = new RandomIntsForDays();

            subject.GenerateNumber();
            var firstNumber = subject.CurrentNumber;
            subject.GenerateNumber();
            var secondNumber = subject.CurrentNumber;
            
            firstNumber.ShouldNotBe(secondNumber);
        }

        [Fact]
        public void StartWithNoSubscribers()
        {
            var subject = new RandomIntsForDays();

            subject.Subscribers.Count().ShouldBe(0);
        }

        [Fact]
        public void AddSubscribers()
        {
            var subject = new RandomIntsForDays();
            var numberFan = new NumberFan();

            subject.AddSubscriber(numberFan);
            
            subject.Subscribers.Count().ShouldBe(1);
        }
    }
}