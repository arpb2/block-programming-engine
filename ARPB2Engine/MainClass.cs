using System;
using ARPB2Engine.Model;
using Boolean = ARPB2Engine.Model.Boolean;

namespace ARPB2Engine
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Equals<Boolean> equals = new Equals<Boolean>
            {
                LeftHand = new Boolean(true),
                RightHand = new Boolean(false)
            };

            System.Console.WriteLine("Result: " + equals.Execute());
            Function function = new Function(print);
            If @if = new If(function);
            @if.conditions.Add(equals);
            @if.Execute();

            Equals<Number> equalsNumber = new Equals<Number>
            {
                LeftHand = new Number(10),
                RightHand = new Number(15)
            };

            System.Console.WriteLine("Result: " + equalsNumber.Execute());
            Function function2 = new Function(print);
            If @if2 = new If(function2);
            @if2.conditions.Add(equalsNumber);
        }

        static int print(string str)
        {
            System.Console.WriteLine(str);
            return 0;
        }
    }
}
