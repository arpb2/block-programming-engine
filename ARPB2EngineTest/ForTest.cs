using System;
using ARPB2Engine.Model;
using Xunit;

namespace ARPB2EngineTest
{
    public class ForTest
    {
        [Fact]
        public void TestFor()
        {
            int counter = 0;
            int repetitions = 5;
            For aLoop = new For(counter, repetitions);

            int globalCheck = 0;

            void CallMe5Times()
            {
                globalCheck++;
            }

            aLoop.ExecuteHandler(CallMe5Times);
            Assert.Equal(globalCheck, 5);
        }
    }
}
