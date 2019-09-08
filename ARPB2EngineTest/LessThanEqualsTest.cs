using System;
using ARPB2Engine.Model;
using ARPB2Engine.Model.Operators;
using Xunit;

namespace ARPB2EngineTest
{
    public class LessThanEqualsTest
    {
        [Theory]
        [InlineData(2, 3, true)]
        [InlineData(100, 100, true)]
        [InlineData(33, 13, false)]
        public void TestLessThanEquals(int number1, int number2, bool expectedResult)
        {
            LessThanEquals<Number> gt = new LessThanEquals<Number>
            {
                LeftHand = new Number(number1),
                RightHand = new Number(number2)
            };
            Assert.Equal(expectedResult, gt.Execute());
        }
    }
}
