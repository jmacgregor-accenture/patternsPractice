using ObserverAtPlay.Library;
using Shouldly;
using Xunit;

namespace ObserverAtPlay.Tests
{
    public class NumberFanShould
    {
        [Fact]
        public void HaveFavoriteNumber()
        {
            var subscriber = new NumberFan();

            subscriber.FavoriteNumber.ShouldBeOfType<int>();
        }
    }
}