/* Trooper Class Definition File
 * Author: Clint MacDonald
 * Date: March 8, 2022
 */
#region Using
using System;
using System.Collections.Generic;
using System.IO;
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

        public static void FileWrite(List<Trooper> troopers, String fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs); // The only thing this needs is the file stream
            sw.Write(FileCreateCSV(troopers));
            sw.Close();
        }

        private static String FileCreateCSV(List<Trooper> troopers)
        {
            String returnString = string.Empty;
            
            foreach (Trooper t in troopers)
            {
                returnString += t.Designation.ToString() + ", "
                                + t.NickName + ", "
                                + t.Unit + ", "
                                // Start   how many characters we want
                                + t.Born.ToString().Substring(0, 10) + ", " // year/month/day = 2022/04/05
                                + t.HomeWorld + ", "
                                + t.IsDefective + ", "
                                + ConvertColourToString(t.HairColor) + ", "
                                + ConvertColourToString(t.EyeColor) + "\n";


            } 


            return returnString;
        }

        private static String ConvertColourToString(Color clr)
        {
            return clr.ToString()
                .Replace("Color [", "")  // ("replace this", "with this")
                .Replace("]", "")
                .Replace(" ", "")
                .Replace("A=", "")
                .Replace("R=", "")
                .Replace("G=", "")
                .Replace("B=", "")
                .Replace(",", ";");
        }

        public static List<Trooper> LoadFromCSV(String fileName)
        {
            List<Trooper> returnList = new List<Trooper>();

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            String lineContent = string.Empty;
            String[] items = new string[8];
            String[] dateItems = new string[2];
            Trooper t;

            while (!sr.EndOfStream)
            {
                try
                {
                    lineContent = sr.ReadLine();
                    items = lineContent.Split(",");
                    t = new Trooper();
                    t.Designation = Convert.ToInt32(items[0]);
                    t.NickName = items[1];
                    t.Unit = items[2];
                    //t.Born
                    dateItems = items[3].Split("-");
                    t.Born = new DateTime(Convert.ToInt32(dateItems[0]),
                                          Convert.ToInt32(dateItems[1]),
                                          Convert.ToInt32(dateItems[2]));

                    t.HomeWorld = items[4];
                    t.IsDefective = Convert.ToBoolean(items[5]);
                    t.HairColor = ConvertStringToColour(items[6]);
                    t.EyeColor = ConvertStringToColour(items[7]);

                    returnList.Add(t);
                }
                catch { 
                
                }
            }


            return returnList;
        }

        private static Color ConvertStringToColour(String clr)
        {
            Color rc;

            if (clr.Contains(";"))
            {
                string[] items = new string[3];
                items = clr.Split(";");
                rc = Color.FromArgb(Convert.ToInt32(items[0]),
                                    Convert.ToInt32(items[1]),
                                    Convert.ToInt32(items[2]),
                                    Convert.ToInt32(items[3]));
            }
            else
            {
                rc = Color.FromName(clr);
            }

            return rc;
        }

        #endregion
    }
}
