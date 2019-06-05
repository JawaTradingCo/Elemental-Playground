using System;
using System.Drawing;

namespace Elemental_Playground
{
    class Tool
    {
        public string name;
        public string description;
        public int category;
        public bool visibleInMenu;
        public Color color;

        public virtual void Perform(int x, int y, Simulation sim) { }
    }
}
