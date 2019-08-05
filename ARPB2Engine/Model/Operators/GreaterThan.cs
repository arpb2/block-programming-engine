using System;
namespace ARPB2Engine.Model.Operators
{
    public class GreaterThan<T> : Operator
    {
        public ILiteral<T> LeftHand { get; set; }
        public ILiteral<T> RightHand { get; set; }

        public GreaterThan()
        {
        }

        public override bool Execute()
        {
            if (LeftHand.Equals(typeof(Number)) || RightHand.Equals(typeof(Number)))
            {
                return (int)LeftHand.GetValue() > (int)RightHand.GetValue();
            }
            else
            {
                // TODO: Return exception
                return false;
            }
        }
    }
}
