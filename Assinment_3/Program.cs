using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: Abhinav Sharda
 * StudentNumber: 300868625
 * Description: The Driver class for Planet classes and Interfaces
 * DateCreated: July 7rd, 2016
 */
namespace Assinment_3
{
    /**
     * this class is the driver class for my program
     * @class Program
     */
    class Program
    {
        /**Main method of driver class
         * 
         * @method Main
         * param {string} args
         */
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            //Giant Planet Specification i.e, Name, Diameter, Mass and Type
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");
            GiantPlanet giantPlanet = new GiantPlanet("Sharda", 700700700700, 700700, "Habitable for Humans ");
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine();
            //Terrestrial Planet's Specs i.e, Name, Diameter, Mass and Type
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("jupitor", 69911, 317898, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine();
        }
        }
    }

