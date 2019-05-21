using System;
using EverCraft.Library;
using Shouldly;
using Xunit;

namespace EverCraft.Tests
{
    public class CharacterShould
    {
        [Fact]
        public void HaveNameAndAlignment()
        {
            var testName = "Bob";
            var testAlignment = Alignment.Evil;

            var character = new Character(testName, testAlignment);
            
            character.Name.ShouldBe(testName);
            character.Alignment.ShouldBe(testAlignment);
        }

        [Fact]
        public void HaveDefaultArmorAndHitPoints()
        {
            var testName = "Bob";
            var testAlignment = Alignment.Evil;

            var character = new Character(testName, testAlignment);

            character.HitPoints.ShouldBe(5);
            character.Armor.ShouldBe(10);
        }
    }
}