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
    }
}