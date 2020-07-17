using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giant1 = new GiantPlanet("Chad",11.5f, 10.5f, "round");
            GiantPlanet giant2 = new GiantPlanet("vinus", 5.4f, 15.4f, "blind");

            TerrestrialPlanet terrestrialPlanet1 = new TerrestrialPlanet("Mason", 22.4f, 23.8f, false);
            TerrestrialPlanet terrestrialPlanet2 = new TerrestrialPlanet("Earth", 35.9f, 41.6f, true);

            Console.WriteLine(giant1);
            Console.WriteLine(giant2);
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine(terrestrialPlanet1);
            Console.WriteLine(terrestrialPlanet2);

            WaitForAnyKey();
        }

        public static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
