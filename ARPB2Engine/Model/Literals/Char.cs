using System;
namespace ARPB2Engine.Model
{
    public class Character : ILiteral, IEquatable<Character>
    {
        char value;
        public Character(char value)
        {
            this.value = value;
        }

        public bool Equals(Character other)
        {
            return (char)value == (char)other.value;
        }

        object ILiteral.GetValue()
        {
            return value;
        }
    }
}
