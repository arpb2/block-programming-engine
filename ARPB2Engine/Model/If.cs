using System;
using System.Collections.Generic;

namespace ARPB2Engine.Model
{
    public class If : Statement
    {
        public List<Operator> conditions { get; set; }
        public Statement thenStatement;

        public If(Statement statement)
        {
            conditions = new List<Operator>();
            thenStatement = statement;
        }

        public void Execute()
        {
            bool allOK = true;
            foreach (Operator condition in conditions)
            {
                if (!condition.Execute())
                {
                    allOK = false;
                    break;
                }
            }
            if (allOK)
            {
                //System.Console.WriteLine("then");
                thenStatement.Execute();
            }
        }
    }
}