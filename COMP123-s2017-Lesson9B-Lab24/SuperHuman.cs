using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 11, 2017
 * Description: This is the SuperHuman class
 * Version:0.1 - Created the SuperHuman class
 */
namespace COMP123_s2017_Lesson9B_Lab24
{
    public class SuperHuman
    {
        //Private instant variables
        private List<Power> _powers;
        //Public properties
        public List<Power> Powers
        {
            get
            {
                return this._powers;
            }
        }
       
    }
}