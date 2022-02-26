#region Class Written By:
/*
 * Author:          Martin Barber
 * Date:            Feb 22nd, 2022
 * Student ID:      100368442
 * Title: NETD:     Week07 Demo Droids
 * Description:     This is the class for the Demo file about the Droid manufacturing 
 * https://github.com/Ritz-Bitz13/NETD2022_WInter2022_04
 * 
 */
#endregion

#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace W7_Demo_Classes1
{


    #region Main Droid Class
    class Droid
    {

        public static List<Droid> Droids = new List<Droid>();


        public const int MinDesignationLength = 3;
        public const int MaxDesignationLength = 8;
        public const int MinOwnerLength = 5;

        #region Properties
        public string Designation { get; set; } //type prop and tab twice to get this <-----
        //                       get = accessor
        //                            set = mutator
        public bool IsInService { get; set; }
        public string Owner { get; set; }
        public Color PrimaryColor  { get; set; }
        public Color SecondaryColor { get; set; }

        // If you need to add a validation (if statement) you must do it the long way
        //public string ItIsValid
        //{
        // get
        // {
        //     return _valid;
        // }
        // set
        // {
        //     _valid = value;
        // }
        //}

        #region Constructors
        //YOU MUST HAVE A CONSTRUCTOR

        /// <summary>
        /// Default Droid Constructor
        /// </summary>
        public Droid() {
            //defaults to not leave a NULL
            Designation = string.Empty;
            Owner = string.Empty;
            PrimaryColor = Color.Gray;
            SecondaryColor = Color.Gray;
            IsInService = false;
        }

        /// <summary>
        /// Input Value constructor
        /// </summary>
        /// <param name="designation">The name of the Droid</param>
        /// <param name="isInService"> Is the droid being used</param>
        /// <param name="owner">The name of the current owner</param>
        /// <param name="primaryColor">The Main colour recognizing the droid</param>
        /// <param name="secondaryColor">Any secondary colour to recognize the droid</param>
        public Droid (string designation, bool isInService, string owner, Color primaryColor, Color secondaryColor)
        {
            Designation = designation;
            IsInService = isInService;
            Owner = owner;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }
        #endregion


        #region Custom Methods
        public static Droid FindDroid(string designation)
        {
            Droid returnDroid = new Droid();
            // look through the list until we find the droid we are looking for
            foreach (Droid d in Droids)
            {
                if (d.Designation == designation)
                {
                    return d;
                }
            }
            return returnDroid;
        }

        #endregion


        #region

        #endregion

        #region

        #endregion




        #endregion



    }
    #endregion
}
