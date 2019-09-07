using System;
using ARPB2Engine.Model.Operators;
using Boolean = ARPB2Engine.Model.Boolean;
using Xunit;

namespace ARPB2EngineTest
{
    public class EqualsTest
    {
        [Fact]
        public void TestEquals()
        {
            Equals<Boolean> equals = new Equals<Boolean>
            {
                LeftHand = new Boolean(true),
                RightHand = new Boolean(false)
            };
            Assert.False(equals.Execute());
        }
    }
}
