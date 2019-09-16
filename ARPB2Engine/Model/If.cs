using System;
using System.Collections.Generic;
using ARPB2Engine.Model.Operators;

namespace ARPB2Engine.Model
{
    public class If
    {
        public List<Operator> conditions { get; set; }
        public delegate void ThenStatement(string asd);

        public If()
        {
            conditions = new List<Operator>();
        }

        public void ExecuteHandler(ThenStatement handler, string arg1)
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
                handler(arg1);
            }
        }
    }
}