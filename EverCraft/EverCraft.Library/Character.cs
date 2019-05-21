using System;

namespace EverCraft.Library
{
    public class Character
    {
        public string Name { get; }
        public Alignment Alignment { get; }
        public int HitPoints { get; set; }
        public int Armor { get; set; }
        public bool IsAlive { get; set; }

        public Character(string name, Alignment alignment)
        {
            Name = name;
            Alignment = alignment;
            HitPoints = 5;
            Armor = 10;
            IsAlive = true;
        }

        public bool Attack(int dieRoll, Character opponent)
        {
            if (dieRoll >= opponent.Armor)
            {
                opponent.TakeDamage();
                return true;
            }

            return false;
        }

        public void TakeDamage()
        {
            HitPoints--;

            if (HitPoints <= 0)
            {
                IsAlive = false;
            }
        }
    }
}