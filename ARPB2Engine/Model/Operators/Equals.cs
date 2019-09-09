using System;
namespace ARPB2Engine.Model.Operators
{
    public class Equals : Operator
    {
        public ILiteral LeftHand { get; set; }
        public ILiteral RightHand { get; set; }

        public Equals()
        {
        }

        public override bool Execute()
        {
            return LeftHand.GetValue().Equals(RightHand.GetValue());
        }
    }
}
