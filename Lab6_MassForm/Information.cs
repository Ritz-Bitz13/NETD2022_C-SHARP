#region App Created by:
/*
 * Author:          Martin Barber
 * Date:            March 30th, 2022 - April 4th, 2022
 * Student ID:      100368442
 * Title: NETD:     Lab 5: Text File Creater
 * https://github.com/Ritz-Bitz13/NETD2022_WInter2022_04
 */
#endregion

#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
#endregion

namespace Lab6_MassForm
{
    #region Class
    public class Information
    {
        public String Info { get; set; }


        public  Information() { }

        public Information(String info)
        {
            Info = info;

        }

        public static List<Information> Document = new List<Information>();
        #endregion

        #region FileWrite
        /// <summary>
        /// This will Write the file name to the computer itself.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="filename"></param>
        public static void FileWrite(List<Information> document, String filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(CreateFileCVS(document));
            sw.Close();
        }
        #endregion

        #region Create File
        /// <summary>
        /// This will take the information from the textbox and convert it to a string.
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static String CreateFileCVS(List<Information> info)
        {
            String documents = string.Empty;

            foreach (Information i in info)
            {
                documents += i.Info.ToString() + "\n"; // Writes the information from the textbox and the \n ends the file.
            }

            return documents;
        }


        #endregion
    }
}
