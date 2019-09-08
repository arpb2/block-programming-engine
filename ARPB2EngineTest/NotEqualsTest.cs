using System;
using ARPB2Engine.Model.Operators;
using Xunit;

namespace ARPB2EngineTest
{
    public class NotEqualsTest
    {
        [Theory]
        [InlineData("foo", "bar", true)]
        [InlineData("asd", "wed", true)]
        [InlineData("blue", "blue", false)]
        public void TestNotEquals(String string1, String string2, bool expectedResult)
        {
            NotEquals<ARPB2Engine.Model.String> gt = new NotEquals<ARPB2Engine.Model.String>
            {

                LeftHand = new ARPB2Engine.Model.String(string1),
                RightHand = new ARPB2Engine.Model.String(string2)
            };


            Assert.Equal(expectedResult, gt.Execute());
        }
    }
}
