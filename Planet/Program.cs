using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================================");
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 120268, 56836000, "Hydrogen", 53, 7);
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("================================================================================");
            Console.WriteLine("================================================================================");
            TerrestialPlanet terrestialPlanet = new TerrestialPlanet("venus", 120581, 4867500, true, 0);
            Console.WriteLine(terrestialPlanet.ToString());
            Console.WriteLine("================================================================================");
         
        }
      
    }
}
