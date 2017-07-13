using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: This is the SuperHuman class
 * Version:0.1 - Added AddPower class from SuperHuman class
 *              -Added DisplayPower method to SuperHuman class
 */
namespace COMP123_s2017_Lesson9B_Lab24
{
    /// <summary>
    /// This s the SuperHuman class
    /// </summary>
    public class SuperHuman : Human
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
        //Constructor
        /// <summary>
        /// This is the main constructor for the SuperHuman class.
        /// It takes one parameter - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialized();
        }
        //Private Methods
        /// <summary>
        /// This method initializes, instantiates and assigns values to class properties
        /// </summary>
        private void _initialized()
        {
            this._powers = new List<Power>();//creates an empty list
        }
        //Public Methods

        /// <summary>
        /// This method adds a power to the power list
        /// It takes two parameters- name(string)- rank(int) 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        /// <summary>
        /// This method displays each of the power listed in Power list
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + "Rank: " + power.Rank);
            }
        }
        public override string ToString()
        {
            string outputstring = "";
            outputstring += "======================================\n";
            outputstring += "SuperHuman Name: " + this.Name + "\n";
            outputstring += "=======================================\n";
            foreach (Power power in this.Powers)
            {
                outputstring += "Power: " + power.Name + "Rank: " + power.Rank + "\n";

            }
            outputstring += "=======================================\n";
            return outputstring;
        }
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}