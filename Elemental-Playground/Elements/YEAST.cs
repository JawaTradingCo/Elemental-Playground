using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Elemental_Playground.Elements
{
    class YEAST : Element
    {
        private static YEAST instance;

        public static YEAST Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new YEAST();
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
                Instance.color);
        }

        private YEAST()
        {
            name = "YEAST";
            description = "Yeast. Grows when warm.";
            category = CONST.CATEGORY_POWDER;
            visibleInMenu = true;
            color = Color.FromArgb(238, 224, 192);

            prop = CONST.TYPE_POWDER | CONST.PROP_MOVABLE;
            temperature = CONST.ROOM_TEMP;
            density = 66;
            updateMoveIterations = 0;
            stability = 0;
            fallingStability = 98;
            conductivity = 0;

            lowTemperature = CONST.K_TO_C + 0;
            lowTemperatureTransition = typeof(DYAST);
            highTemperature = CONST.K_TO_C + 105;
            highTemperatureTransition = typeof(DYAST);

            Update = YEAST.update;
        }

        public static void update(Particle p, Simulation sim)
        { 
            if (CONST.K_TO_C + 28 <= p.temperature &&
                p.temperature <= CONST.K_TO_C + 45)
                sim.SetElement(p.x + sim.GetRandom(3) - 1,
                    p.y + sim.GetRandom(3) - 1,
                    YEAST.Instance);
        }
    }
}