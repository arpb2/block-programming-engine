using System;
namespace ARPB2Engine.Model.Operators
{
    public class NotEquals : Operator
    {
        public ILiteral LeftHand { get; set; }
        public ILiteral RightHand { get; set; }

        public NotEquals()
        {
        }

        public override bool Execute()
        {
            return !LeftHand.GetValue().Equals(RightHand.GetValue());
        }
    }
}
