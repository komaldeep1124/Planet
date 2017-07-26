using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    /// <summary>
    /// name:komaldeep kaue
    /// student no:300926834
    /// this is gaintplanet sub class inherirted from planets.
    /// </summary>
    public class GiantPlanet : Planets    
    {
        //private instance variables
        private string _type;
        private int _moonCount;
        private int _ringCount;
        //constructor-------
        /// <summary>
        /// this is constructor for giantplanet.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        /// <param name="moonCount"></param>
        /// <param name="ringCount"></param>
        public GiantPlanet(string name, double diameter, double mass, string type, int moonCount, int ringCount) : base(name, diameter, mass)
        {
            _type = type;
            _moonCount = moonCount;
            _ringCount = ringCount;
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
        public bool HasRings()
        {
            if (RingCount > 0)
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
