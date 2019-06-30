﻿using System;
namespace ARPB2Engine.Model
{
    public abstract class Operator : IExecutable
    {
        String identifier;

        public Operator()
        {
        }

        public abstract bool Execute();

        void IExecutable.Execute()
        {
            throw new NotImplementedException();
        }
    }
}
