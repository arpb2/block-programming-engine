using System;
using ARPB2Engine.Model;
using ARPB2Engine.Model.Operators;
using Xunit;

namespace ARPB2EngineTest
{
    public class LessThanTest
    {
        [Theory]
        [InlineData(1, 2, true)]
        [InlineData(100, 500, true)]
        [InlineData(25, 14, false)]
        public void TestGreaterThanEquals(int number1, int number2, bool expectedResult)
        {
            LessThan<Number> gt = new LessThan<Number>
            {
                LeftHand = new Number(number1),
                RightHand = new Number(number2)
            };
            Assert.Equal(expectedResult, gt.Execute());
        }
    }

}
