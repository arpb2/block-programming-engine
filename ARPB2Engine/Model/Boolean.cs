using System;
namespace ARPB2Engine.Model
{
    public class Boolean : ILiteral<Boolean>, IEquatable<Boolean>
    {
        bool value;
        public Boolean(bool value)
        {
            this.value = value;
        }

        public bool Equals(Boolean other)
        {
            return (bool)value == (bool)other.value;
        }

        object ILiteral<Boolean>.GetValue()
        {
            return value;
        }
    }
}
