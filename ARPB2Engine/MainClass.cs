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

            Equals<Character> equalsChar = new Equals<Character>
            {
                LeftHand = new Character('a'),
                RightHand = new Character('a')
            };

            System.Console.WriteLine("Result: " + equalsChar.Execute());
            Function function3 = new Function(print);
            If @if3 = new If(function3);
            @if3.conditions.Add(equalsChar);

            Equals<Model.String> equalsString = new Equals<Model.String>
            {
                LeftHand = new Model.String("holu"),
                RightHand = new Model.String("holu")
            };

            System.Console.WriteLine("Result: " + equalsString.Execute());
            Function function4 = new Function(print);
            If @if4 = new If(function4);
            @if4.conditions.Add(equalsString);
        }

        static int print(string str)
        {
            System.Console.WriteLine(str);
            return 0;
        }
    }
}
