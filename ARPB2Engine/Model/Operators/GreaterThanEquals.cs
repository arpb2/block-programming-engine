﻿using System;
namespace ARPB2Engine.Model.Operators
{
    public class GreaterThanEquals<T> : Operator
    {
        public ILiteral<T> LeftHand { get; set; }
        public ILiteral<T> RightHand { get; set; }

        public GreaterThanEquals()
        {
        }

        public override bool Execute()
        {
            if (LeftHand.Equals(typeof(Number)) || RightHand.Equals(typeof(Number)))
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
