using System;
namespace ARPB2Engine.Model
{
    public class Equals : Operator
    {
        public ILiteral<Boolean> LeftHand { get; set; }
        public ILiteral<Boolean> RightHand { get; set; }

        public Equals()
        {
        }

        public override bool Execute()
        {
            return LeftHand.GetValue().Equals(RightHand.GetValue());
        }
    }
}
