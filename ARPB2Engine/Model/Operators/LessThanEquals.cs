﻿using System;
namespace ARPB2Engine.Model.Operators
{
    public class LessThanEquals<T> : Operator
    {
        public ILiteral<T> LeftHand { get; set; }
        public ILiteral<T> RightHand { get; set; }

        public LessThanEquals()
        {
        }

        public override bool Execute()
        {
            if (LeftHand.GetType().Equals(typeof(Number)) && RightHand.GetType().Equals(typeof(Number)))
            {
                return (int)LeftHand.GetValue() <= (int)RightHand.GetValue();
            }
            else
            {
                // TODO: Return exception
                return false;
            }
        }
    }
}
