using System;
using ARPB2Engine.Model;
using Boolean = ARPB2Engine.Model.Boolean;

namespace ARPB2Engine
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Equals equals = new Equals
            {
                LeftHand = new Boolean(true),
                RightHand = new Boolean(true)
            };

            System.Console.WriteLine("Result: " + equals.Execute());
            Function function = new Function(print);
            If @if = new If(function);
            @if.conditions.Add(equals);
            @if.Execute();
        }

        static int print(string str)
        {
            System.Console.WriteLine(str);
            return 0;
        }
    }
}
