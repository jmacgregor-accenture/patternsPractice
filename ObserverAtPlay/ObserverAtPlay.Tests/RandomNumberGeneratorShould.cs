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
    }
}