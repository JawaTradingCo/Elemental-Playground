using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Elemental_Playground.Elements;

namespace Elemental_Playground.Tools
{
    class WREMV : Tool
    {
        private static WREMV instance;

        public static WREMV Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WREMV();
                }
                return instance;
            }
        }

        public static UIInformation GetUIInformation()
        {
            return new UIInformation(Instance.name,
                Instance.description,
                Instance.category,
                Instance.visibleInMenu,
                Instance.color,
                CONST.BRUSH_SHAPE_SQUARE);
        }

        private WREMV()
        {
            name = "WREMV";
            description = "Wall remover.";
            category = CONST.CATEGORY_WALL;
            visibleInMenu = true;
            color = Color.FromArgb(120, 120, 120);
        }

        public override void Perform(int x, int y, Simulation sim)
        {
            if (sim.BoundsCheck(x, y) &&
                sim.pmap[y, x] != null &&
                (sim.pmap[y, x].elem.prop & CONST.TYPE_WALL) != 0)
            {
                sim.Remove(x, y, true);
            }
        }
    }
}