using System;
namespace ARPB2Engine.Model.Operators
{
    public class GreaterThanEquals : Operator
    {
        public ILiteral LeftHand { get; set; }
        public ILiteral RightHand { get; set; }

        public GreaterThanEquals()
        {
        }

        public override bool Execute()
        {
            if (LeftHand.GetType().Equals(typeof(Number)) && RightHand.GetType().Equals(typeof(Number)))
            {
                return (int)LeftHand.GetValue() >= (int)RightHand.GetValue();
            }
            else
            {
                // TODO: Return exception
                return false;
            }
        }
    }
}
