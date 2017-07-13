using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: COMP123 Lesson09 Lab 24
 * Version:0.2 - Program class modified
 */
namespace COMP123_s2017_Lesson9B_Lab24
{
    class Program
    {
        static void Main(string[] args)
        {

            SuperHuman superHuman = new SuperHuman("Super Dude");

            superHuman.AddPower("Spider Climbing", 50);
            superHuman.AddPower("Webcasting", 45);
        }
    }
}
