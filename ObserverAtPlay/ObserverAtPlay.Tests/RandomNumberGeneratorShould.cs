using System.Collections.Generic;
using System.Linq;
using NSubstitute;
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

            subject.Subscribers.Count.ShouldBe(0);
        }

        [Fact]
        public void AddSubscribers()
        {
            var subject = new RandomIntsForDays();
            var numberFan = new NumberFan();

            subject.AddSubscriber(numberFan);
            
            subject.Subscribers.Count.ShouldBe(1);
        }

        [Fact]
        public void NotifySubscribers()
        {
            var subject = new RandomIntsForDays();
            var numberFan = Substitute.For<ISubscriber>();
            subject.AddSubscriber(numberFan);
            
            subject.GenerateNumber();

            numberFan.Received().Notify(Arg.Is(subject.CurrentNumber));
        }

        [Fact]
        public void NotifySubscribersMultipleTimes()
        {
            var subject = new RandomIntsForDays();
            var numberFan = Substitute.For<ISubscriber>();
            subject.AddSubscriber(numberFan);
            var expectedValues = new List<int>();
            
            subject.GenerateNumber();
            expectedValues.Add(subject.CurrentNumber);
            subject.GenerateNumber();
            expectedValues.Add(subject.CurrentNumber);
            subject.GenerateNumber();
            expectedValues.Add(subject.CurrentNumber);
            
            numberFan.Received(3).Notify(Arg.Is<int>(x => expectedValues.Contains(x)));

        }
    }
}