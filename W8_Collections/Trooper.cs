#region Program Written By:
/*
 * Author:          Martin Barber
 * Date:            March 8th, 2022
 * Student ID:      100368442
 * Title: NETD:     Week 8: Collections
 * Description:     
 * https://github.com/Ritz-Bitz13/NETD2022_WInter2022_04
 */
#endregion

#region Using Systems
using System;
using System.Collections.Generic;
using System.Drawing; // REMEMBER TO ADD THIS BECAUSE WE ARE DEALING WITH COLORS
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Week08_Collections
{
    class Trooper
    {
        #region Properties
        // Properties is your objects
        // If you ever do a string, use a capital on the S to make it a type
        public int Designation { get; set; }
        public String NickName { get; set; }
        public String HomeWorld { get; set; }
        public DateTime Born { get; set; }
        public String Unit { get; set; }
        public Boolean IsDefective { get; set; }
        public Color HairColor { get; set; }
        public Color EyeColor { get; set; }
        #endregion

        #region Constructors
        //Default constructor
        /// <summary>
        /// Default Constructor - By Martin
        /// </summary>
        public Trooper() { }

        //Full info constructor
        /// <summary>
        /// This is my input parameter constructor - by Martin
        /// </summary>
        /// <param name="designation"></param>
        /// <param name="nickName"></param>
        /// <param name="homeWorld">The world the trooper was BORN on.</param>
        /// <param name="born"></param>
        /// <param name="unit">The unit number the trooper is in.</param>
        /// <param name="isDefective">Is there any defective parts of the trooper.</param>
        /// <param name="hairColor">What colour is their hair.</param>
        /// <param name="eyeColor">What colour is their eyes.</param>
        public Trooper(int designation, String nickName, String homeWorld, DateTime born, String unit, 
            Boolean isDefective, Color hairColor, Color eyeColor)
        {
            // IF YOU HAVE DATA VALIDATION THIS IS WHERE YOU DO IT!!!!!
            Designation = designation;
            NickName = nickName;
            HomeWorld = homeWorld;
            Born = born;
            Unit = unit;
            IsDefective = isDefective;
            HairColor = hairColor;
            EyeColor = eyeColor;
        }

        #endregion

        #region Methods (DO STUFF)

        #region Custom Methods (Instantiated)

        #endregion

        #region Static Methods
        //Items that are not copied into the method
        //populates default troopers when the form opens
        
        /// <summary>
        /// Temperary Method to populate some sample troopers for testing purposes.
        /// </summary>
        /// <returns></returns>
        public static List<Trooper> GetSampleTroopers()
        {
            List<Trooper> returnList = new List<Trooper>();

            returnList.Add(new Trooper(1, "Martin", "Tatooine", new DateTime(2022, 05, 16), "Blue", false, Color.Brown, Color.Green));
            returnList.Add(new Trooper(2, "Clint", "Hoth", new DateTime(2021, 02, 22), "Green", false, Color.Blue, Color.Brown));
            returnList.Add(new Trooper(3, "Gillian", "Tatooine", new DateTime(2020, 03, 05), "Red", false, Color.Black, Color.Green));


            return returnList;
        }

        public static List<String> GetUniqueUnits(List<Trooper> inputTroopers)
        {
            List<String> returnList = new List<String>();

            foreach (Trooper t in inputTroopers)
            {
                if(!returnList.Contains(t.Unit))
                {
                    returnList.Add(t.Unit);
                }
            }
            return returnList;
        }

        public static Trooper FindTrooper(List<Trooper> inputTroopers, int designation)
        {
            return inputTroopers.Find(t => t.Designation == designation);

           /* foreach (Trooper t in inputTroopers)
                {
                if (t.Designation == designation)
                    return t;
                } 
                return null;*/
        }

        public static Boolean TrooperExists(List<Trooper> inputTroopers, int designation)
        {
            return inputTroopers.FindAll(t => t.Designation == designation).Count > 0;
        }
        #endregion

        #endregion

    }
}
