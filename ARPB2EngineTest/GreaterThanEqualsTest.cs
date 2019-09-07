using System;
using ARPB2Engine.Model;
using ARPB2Engine.Model.Operators;
using Xunit;

namespace ARPB2EngineTest
{
    public class GreaterThanEqualsTest
    {
        [Theory]
        [InlineData(3, 2, true)]
        [InlineData(100, 100, true)]
        [InlineData(3, 25, false)]
        public void TestGreaterThanEquals(int number1, int number2, bool expectedResult)
        {
            GreaterThanEquals<Number> gt = new GreaterThanEquals<Number>
            {
                LeftHand = new Number(number1),
                RightHand = new Number(number2)
            };
            Assert.Equal(expectedResult, gt.Execute());
        }
    }
}
