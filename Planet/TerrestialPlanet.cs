using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{/// <summary>
/// name:komaldeep kaur
/// student no:300926834
/// this terrestial planet sub class
/// </summary>
   public class TerrestialPlanet: Planets,IHasMoons,IHabitable
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen;
        private int _moonCount;
        //constructor---
        /// <summary>
        /// the methods in terrestial planets class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        /// <param name="moonCount"></param>
        public TerrestialPlanet(string name, double diameter, double mass, bool oxygen, int moonCount) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
            _moonCount = moonCount;
        }
        public bool Habitable()
        {
            if (_oxygen == true)
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


    }
}
