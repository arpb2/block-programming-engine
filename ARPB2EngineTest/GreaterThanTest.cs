using System;
using ARPB2Engine.Model;
using ARPB2Engine.Model.Operators;
using Xunit;

namespace ARPB2EngineTest
{
    public class GreaterThanTest
    {
        [Theory]
        [InlineData(15, 5, true)]
        [InlineData(10, 100, false)]
        public void TestGreaterThan(int number1, int number2, bool expectedResult)
        {
            GreaterThan gt = new GreaterThan
            {
                LeftHand = new Number(number1),
                RightHand = new Number(number2)
            };
            Assert.Equal(expectedResult, gt.Execute());
        }
    }
}
