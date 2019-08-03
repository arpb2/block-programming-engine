using System;
namespace ARPB2Engine.Model
{
    public class Number : ILiteral<Number>, IEquatable<Number>
    {
        int value;
        public Number(int value)
        {
            this.value = value;
        }

        public bool Equals(Number other)
        {
            return value == other.value;
        }


        object ILiteral<Number>.GetValue()
        {
            return value;
        }
    }
}
