using System;

namespace EverCraft.Library
{
    public class Character
    {
        public string Name { get; }
        public Alignment Alignment { get; }

        public Character(string name, Alignment alignment)
        {
            Name = name;
            Alignment = alignment;
        }
    }
}