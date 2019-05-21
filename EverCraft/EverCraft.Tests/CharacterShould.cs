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

        [Fact]
        public void TakeDamage()
        {
            var character = new Character("Eric", Alignment.Evil);
            var startingHP = character.HitPoints;

            character.TakeDamage();
            
            character.HitPoints.ShouldBe(startingHP - 1);
        }

        [Fact]
        public void DamageEnemiesWhenDieRollIsHighEnough()
        {
            var character = new Character("Graham", Alignment.Good);
            var opponent = new Character("John", Alignment.Neutral);
            var dieRoll = 10;

            var result = character.Attack(dieRoll, opponent);

            result.ShouldBeTrue();
        }
    }
}