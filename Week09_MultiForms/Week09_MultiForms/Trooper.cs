/* Trooper Class Definition File
 * Author: Clint MacDonald
 * Date: March 8, 2022
 */
#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
#endregion

namespace Week09_MultiForms
{
    public class Trooper
    {

        #region PROPERTIES

        public int Designation { get; set; }
        public String NickName { get; set; }
        public String HomeWorld { get; set; }
        public DateTime Born { get; set; }
        public String Unit { get; set; }
        public Boolean IsDefective { get; set; }
        public Color HairColor { get; set; }
        public Color EyeColor { get; set; }

        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Default Constructor - by Clint
        /// </summary>
        public Trooper() 
        {
            Designation = 0;
        }


        /// <summary>
        /// This is the input parameter constructor - by Clint
        /// </summary>
        /// <param name="designation"></param>
        /// <param name="nickName"></param>
        /// <param name="homeWorld">The world the Trooper was BORN on.</param>
        /// <param name="born"></param>
        /// <param name="unit"></param>
        /// <param name="isDefective"></param>
        /// <param name="hairColor"></param>
        /// <param name="eyeColor"></param>
        public Trooper(int designation, String nickName, String homeWorld,
            DateTime born, String unit, Boolean isDefective,
            Color hairColor, Color eyeColor)
        {
            // TODO: Add data validation here if needed
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

        #region METHODS

        #region CUSTOM METHODS (instantiated)
        #endregion

        #region STATIC METHODS

        /// <summary>
        /// Temp Method to populate some sample troopers for testing purposes
        /// </summary>
        /// <returns></returns>
        public static List<Trooper> GetSampleTroopers()
        {
            List<Trooper> returnList = new List<Trooper>();

            returnList.Add(new Trooper(1, "Clint", "Tatooine", new DateTime(2022, 05, 16),
                            "Blue", false, Color.Brown, Color.Brown));
            returnList.Add(new Trooper(2, "Rex", "Endor", new DateTime(2062, 08, 11),
                            "Red", false, Color.Black, Color.Blue));
            returnList.Add(new Trooper(3, "Ugly", "Hoth", new DateTime(2053, 11, 22),
                                        "Blue", true, Color.Yellow, Color.Red));

            return returnList;
        }

        public static List<String> GetUniqueUnits(List<Trooper> inputTroopers)
        {
            List<String> returnList = new List<String>();

            foreach (Trooper t in inputTroopers)
            {
                if (!returnList.Contains(t.Unit))
                {
                    returnList.Add(t.Unit);
                }
            }


            return returnList;
        }
        
        public static Trooper FindTrooper(List<Trooper> inputTroopers, int designation)
        {
            return inputTroopers.Find(t => t.Designation == designation);

            /*
            foreach (Trooper t in inputTroopers)
            {
                if (t.Designation == designation)
                    return t;
            }
            return null;
            */
        }

        public static Boolean TrooperExists(List<Trooper> inputTroopers, int designation)
        {
            return inputTroopers.FindAll(t => t.Designation == designation).Count > 0;
        }

        #endregion

        #endregion
    }
}
