using System;
namespace ARPB2Engine.Model
{
    public class Function : Statement
    {
        public Func<ILiteral, ILiteral> executable { get; set; }

        public Function(Func<String, Number> func)
        {
            this.executable = (System.Func<ARPB2Engine.Model.ILiteral, ARPB2Engine.Model.ILiteral>)func;
        }

        public Function(Func<String, String> func)
        {
            this.executable = (System.Func<ARPB2Engine.Model.ILiteral, ARPB2Engine.Model.ILiteral>)func;
        }

        public override void Execute()
        {
            executable.Invoke((ARPB2Engine.Model.ILiteral)new String("a"));
        }
    }
}
