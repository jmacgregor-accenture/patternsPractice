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

            var result = subject.GenerateNumber();

            result.ShouldBeOfType<int>();
        }

        [Fact]
        public void GenerateNewNumberEachTime()
        {
            var subject = new RandomIntsForDays();

            var firstNumber = subject.GenerateNumber();
            var secondNumber = subject.GenerateNumber();
            
            firstNumber.ShouldNotBe(secondNumber);
        }

        [Fact]
        public void StartWithNoSubscribers()
        {
            var subject = new RandomIntsForDays();

            subject.Subscribers.Count().ShouldBe(0);
        }
    }
}