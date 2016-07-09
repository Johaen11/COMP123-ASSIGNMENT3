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
 * Version: 0.03 - Final Version
 */

namespace COMP123_ASSIGNMENT3
{
    /**
    * This class is the "driver" class for my Program
    * 
    * @class Program
    */
    class Program
    {
        /**
        * the main method for my driver class Program
        * 
        * @method Main
        * @param {sting[]} args
        * @returns {void}
        */
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 23, 11, "Gas");
            Console.WriteLine(giantPlanet.ToString());
           
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth",23,55,true);
            Console.WriteLine(terrestrialPlanet.ToString());

            WaitForAnyKey();
        }
        /**
         * <summary>
         * Utility method to wait for a console key press from the user 
         * </summary>
         * 
         * @method WaitForAnyKey
         * @returns {void}
         */
        private static void WaitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
