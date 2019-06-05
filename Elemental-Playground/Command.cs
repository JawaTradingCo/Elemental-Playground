using System;

namespace Elemental_Playground
{
    abstract class Command
    {
        public int step;

        public abstract void Execute(Simulation sim);
    }
}
