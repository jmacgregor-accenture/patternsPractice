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

        [Fact]
        public void GetNewFavoriteNumberAfterNotify()
        {
            var subscriber = new NumberFan();
            var newValue = 3;
            
            subscriber.Notify(newValue);
            
            subscriber.FavoriteNumber.ShouldBe(newValue);
        }
    }
}