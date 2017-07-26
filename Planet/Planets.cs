using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    /// <summary>
    /// name:komaldeep kaur
    /// student:300926834
    /// this is my abstract classe:planets.
    /// </summary>
   public abstract class Planets
    {
        //private instance variables.
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        //public properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }
        //CONSTRUCTORS-----------------------------------------------
        /// <summary>
        /// This is the main constructor.
        /// It takes three arguments - name, diameter, mass and assign them to appropriate properties.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planets(string name, double diameter, double mass)
        {
            _name = name;
            _diameter = diameter;
            _mass = mass;
        }
        public override string ToString()
        {
            return string.Format("Name is " + Name + "\n The Diameter is " + Diameter + "km and Mass is " + Mass + "kgs \n");
        }

    }
}
