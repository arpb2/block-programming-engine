using System;
namespace ARPB2Engine.Model
{
    public class Function : Statement
    {
        public Func<ILiteral, ILiteral> executable { get; set; }

        public Function(Func<String, Number> func)
        {
            this.executable = func as Func<ILiteral, ILiteral>;
        }

        public Function(Func<String, String> func)
        {
            this.executable = func as Func<ILiteral, ILiteral>;
        }

        public override void Execute()
        {
            executable.Invoke((ARPB2Engine.Model.ILiteral)new String("a"));
        }
    }
}
