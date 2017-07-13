﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: COMP123 Lesson09 Lab 24
 *  * version:0.3- modified SuperVilian class class
 *  * Version:0.4 - Implmented the SuperVillion class 
 *  
 *   GitHub Link: https://github.com/BishnuKhanal1/COMP123-s2017-Lesson9B-Lab24/commits/master
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

            Console.WriteLine("********* SUPER HERO *********");
            SuperHero superHero = new SuperHero("Super Dude", 20);

            superHero.Powers.Add(new Power("Teleportation", 50));
            superHero.Powers.Add(new Power("Phasing", 40));
            superHero.Powers.Add(new Power("Invisibility", 30));
            Console.WriteLine(superHero.ToString());

            Console.WriteLine("********* SUPER VALLIAN *********");
            SuperHuman superVillian = new SuperVillian("Super Dude", 20);

            superVillian.Powers.Add(new Power("Batman", 50));
            superVillian.Powers.Add(new Power("Glactus", 40));
            superVillian.Powers.Add(new Power("Gambit", 30));
            Console.WriteLine(superVillian.ToString());
        }
    }
}
