using System;
using System.Collections.Generic;

namespace ARPB2Engine.Model
{
    public abstract class Statement : IExecutable
    {
        List<Statement> statements;

        public Statement()
        {
        }

        public virtual void Execute()
        {

        }
    }
}
