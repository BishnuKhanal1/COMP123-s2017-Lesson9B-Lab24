using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: This is the SuperHero class
 * Version:0.1 - Created the SuperHero class
 */
namespace COMP123_s2017_Lesson9B_Lab24
{
    /// <summary>
    /// This is SuperHero class
    /// </summary>
    public class SuperHero : SuperHuman
    {
        //Private fields
        private int _karma;

        //public properties
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }
        //constructrors
        public SuperHero(string name) : base(name)
        {

        }
        //private methods

        //public methods
    }
}