using System;
namespace ARPB2Engine.Model
{
    public class Boolean : ILiteral, IEquatable<Boolean>
    {
        bool value;
        public Boolean(bool value)
        {
            this.value = value;
        }

        public bool Equals(Boolean other)
        {
            return value == other.value;
        }

        object ILiteral.GetValue()
        {
            return value;
        }
    }
}
