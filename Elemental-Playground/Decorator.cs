using System;

namespace Elemental_Playground
{
    abstract class Decorator : Element
    {
        public Element baseElem;

        public Decorator(Element baseElem)
        {
            this.baseElem = baseElem;

            name = baseElem.name;
            color = baseElem.color;

            prop = baseElem.prop;
            temperature = baseElem.temperature;
            density = baseElem.density;
            updateMoveIterations = baseElem.updateMoveIterations;
            fallingStability = baseElem.fallingStability;
            conductivity = baseElem.conductivity;

            lowTemperature = baseElem.lowTemperature;
            lowTemperatureTransition = baseElem.lowTemperatureTransition;
            highTemperature = baseElem.highTemperature;
            highTemperatureTransition = baseElem.highTemperatureTransition;
        }
    }
}
