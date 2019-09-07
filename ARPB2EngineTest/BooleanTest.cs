using System;
using ARPB2Engine.Model;
using Xunit;

namespace ARPB2EngineTest
{
    public class BooleanTest
    {
        [Fact]
        public void TestBoolean()
        {
            ILiteral<ARPB2Engine.Model.Boolean> boolean = new ARPB2Engine.Model.Boolean(true);
            Assert.True((bool)boolean.GetValue());
        }
    }
}
