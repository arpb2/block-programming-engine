using System;
namespace ARPB2Engine.Model
{
    public class String : ILiteral<String>, IEquatable<String>
    {
        string value;
        public String(string value)
        {
            this.value = value;
        }

        public bool Equals(String other)
        {
            return value == other.value;
        }

        object ILiteral<String>.GetValue()
        {
            return value;
        }
    }
}
