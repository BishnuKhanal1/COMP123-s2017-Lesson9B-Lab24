using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: This is the SuperVillian class
 * Version:0.1 - Created the SuperVillian class
 */
namespace COMP123_s2017_Lesson9B_Lab24
{
    /// <summary>
    /// This is the SuperVillian class
    /// </summary>
    public class SuperVillian : SuperHuman, IHasMalice
    {
        //Private fields
        private int _malice;

        //public properties
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }
        //constructrors
        /// <summary>
        /// This is the main constructor for SuperVillian class
        /// It taked one argument-name(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>

        public SuperVillian(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }
    }
 }