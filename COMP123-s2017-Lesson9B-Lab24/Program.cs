using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: COMP123 Lesson09 Lab 24
 * version:0.3- Used the ToString Method of the SuperHuman class
 * Version:0.4 - Implmented the SuperHero class 
 */
namespace COMP123_s2017_Lesson9B_Lab24
{
    class Program
    {
        static void Main(string[] args)
        {

            SuperHuman superHuman = new SuperHuman("Super Dude");

            superHuman.Powers.Add(new Power("Teleportation", 50));
            superHuman.Powers.Add(new Power("Phasing", 40));
            superHuman.Powers.Add(new Power("Invisibility", 30));
            Console.WriteLine(superHuman.ToString());

            SuperHuman superHero = new SuperHero("Super Dude", 20);

            superHero.Powers.Add(new Power("Teleportation", 50));
            superHero.Powers.Add(new Power("Phasing", 40));
            superHero.Powers.Add(new Power("Invisibility", 30));
            Console.WriteLine(superHuman.ToString());
        }
    }
}
