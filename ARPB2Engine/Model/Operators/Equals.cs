using System;
namespace ARPB2Engine.Model.Operators
{
    public class Equals<T> : Operator
    {
        public ILiteral<T> LeftHand { get; set; }
        public ILiteral<T> RightHand { get; set; }

        public Equals()
        {
        }

        public override bool Execute()
        {
            return LeftHand.GetValue().Equals(RightHand.GetValue());
        }
    }
}
