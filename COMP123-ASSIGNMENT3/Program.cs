using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: Johaen Gnanakumar
 * Date: July 7, 2016
 * StudentID: 300880309
 * Description: This Program creates a Giant Planet and Terrestrial Planet
 * Version: 0.01 - Added Header Comment
 */

namespace COMP123_ASSIGNMENT3
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("df", 23, 11, "ok");
            Console.WriteLine(giantPlanet.ToString());
           
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("",23,55,true);
            Console.WriteLine(terrestrialPlanet.ToString());

            WaitForAnyKey();
        }

       private static void WaitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
