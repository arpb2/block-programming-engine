using System;
using ARPB2Engine.Model;
using ARPB2Engine.Model.Operators;
using Xunit;
using String = ARPB2Engine.Model.String;

namespace ARPB2EngineTest
{
    public class IfTest
    {
        [Fact]
        public void TestIf()
        {
            Equals equals = new Equals
            {
                LeftHand = new ARPB2Engine.Model.Boolean(true),
                RightHand = new ARPB2Engine.Model.Boolean(true)
            };

            void Print(string str)
            {
                var res = str + "a";
                Assert.True(res == "aa"); // Seems redundant but it's a workaround to test this delegate was called
            }

            If @if = new If();
            @if.conditions.Add(equals);
            try
            {
                @if.ExecuteHandler(Print, "a");
            }
            catch (Exception ex)
            {
                // There is no Assert.Fail in xUnit
                Assert.True(false, "Expected no exception, but got: " + ex.Message);
            }
        }

        [Fact]
        public void TestThenNotExecuted()
        {
            Equals equals = new Equals
            {
                LeftHand = new ARPB2Engine.Model.Boolean(true),
                RightHand = new ARPB2Engine.Model.Boolean(false)
            };

            void Print(string str)
            {
                var res = str + "a";
                Assert.True(false, "Called when it shouldn't");
            }

            If @if = new If();
            @if.conditions.Add(equals);
            try
            {
                @if.ExecuteHandler(Print, "a");
            }
            catch (Exception ex)
            {
                // There is no Assert.Fail in xUnit
                Assert.True(false, "Expected no exception, but got: " + ex.Message);
            }
        }
    }
}
