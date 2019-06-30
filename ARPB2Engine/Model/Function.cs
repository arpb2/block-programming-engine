using System;
namespace ARPB2Engine.Model
{
    public class Function : Statement
    {
        public Func<string, int> executable { get; set; }

        public Function(Func<string, int> func)
        {
            this.executable = func;
        }

        public override void Execute()
        {
            executable.Invoke("a");
        }
    }
}
