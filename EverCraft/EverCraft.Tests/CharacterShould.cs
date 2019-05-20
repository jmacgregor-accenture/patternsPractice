using System;
using EverCraft.Library;
using Shouldly;
using Xunit;

namespace EverCraft.Tests
{
    public class CharacterShould
    {
        [Fact]
        public void HaveName()
        {
            var testName = "Bob";
            var character = new Character();

            character.Name = testName;

            character.Name.ShouldBe(testName);
        }

        [Fact]
        public void HaveAlignment()
        {
            var testAlignment = Alignment.Good;
            var character = new Character();

            character.Alignment = testAlignment;

            character.Alignment.ShouldBe(testAlignment);
        }
    }
}