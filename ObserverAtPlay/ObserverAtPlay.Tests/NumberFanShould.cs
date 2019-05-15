using NSubstitute;
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

        [Fact]
        public void SubscribeToSubject()
        {
            var subscriber = new NumberFan();
            ISubject subject = Substitute.For<ISubject>();

            subscriber.SubscribeTo(subject);

            subject.Received().AddSubscriber(Arg.Is(subscriber));
            subscriber.Subscription.ShouldBe(subject);
        }
    }
}