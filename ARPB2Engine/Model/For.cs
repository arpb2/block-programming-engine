using System;
namespace ARPB2Engine.Model
{
    public class For
    {
        int counter;
        int repetitions;

        public delegate void DoStatement();

        public For(int counter, int repetitions)
        {
            this.counter = counter;
            this.repetitions = repetitions;
        }

        public void ExecuteHandler(DoStatement handler)
        {
            for (; this.counter < repetitions; this.counter++)
            {
                handler();
            }
        }
    }
}
