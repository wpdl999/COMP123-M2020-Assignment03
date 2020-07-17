using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Assignment03
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        bool _oxygen;

        public bool Habitable()
        {
            if (_oxygen)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) 
            :base(name,diameter,mass)
        {
            this._oxygen = oxygen;
        }
    }
}
