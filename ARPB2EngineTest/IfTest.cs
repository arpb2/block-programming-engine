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
        public void TestIfStringInt()
        {
            Equals equals = new Equals
            {
                LeftHand = new ARPB2Engine.Model.Boolean(true),
                RightHand = new ARPB2Engine.Model.Boolean(false)
            };

            Number Size(String str)
            {

                return new Number(str.ToString().Length);
            }

            Function function = new Function(Size);
            If @if = new If(function);
            @if.conditions.Add(equals);
            @if.Execute();
        }

        [Fact]
        public void TestIfStringString()
        {
            Equals equals = new Equals
            {
                LeftHand = new ARPB2Engine.Model.Boolean(true),
                RightHand = new ARPB2Engine.Model.Boolean(false)
            };

            String Print(String str)
            {
                // TODO: Rethink test
                var res = (str as ILiteral).GetValue() + "a";
                return new String(res);
            }

            Function function = new Function(Print);
            If @if = new If(function);
            @if.conditions.Add(equals);
            @if.Execute();
        }
    }
}
