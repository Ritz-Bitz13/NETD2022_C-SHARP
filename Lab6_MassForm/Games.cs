using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_MassForm
{
    class Games
    {
        public int Designation { get; set; }
        public String GameName { get; set; }
        public String Console { get; set; }
        public String Favourite { get; set; }
        public Boolean Replayable { get; set; }

        #region Constructors
        public Games() { }

        /// <summary>
        /// This is the full list of items to add to the list.
        /// </summary>
        /// <param name="designation">Number in the list</param>
        /// <param name="gameName">Give the name of the game you want to recommend</param>
        /// <param name="console">What console did you play it on?</param>
        /// <param name="favourite">What was your favourite part playing the game</param>
        /// <param name="replayable">Could you play it over and over again and never get tired?</param>
        public Games(int designation, String gameName, String console, String favourite, Boolean replayable)
        {
            Designation = designation;
            GameName = gameName;
            Console = console;
            Favourite = favourite;
            Replayable = replayable;
        }
        #endregion

        #region Static Method
        /// <summary>
        /// This generates 3 sample games to make sure the information displays properly
        /// </summary>
        /// <returns></returns>
        public static List<Games> GetSampleGames()
        {
            List<Games> returnList = new List<Games>();

            returnList.Add(new Games(1, "Legend of Zelda: Ocarina of Time", "N64", "Story", true));
            returnList.Add(new Games(2, "God of War III", "Playstation 3", "Combat", false));
            returnList.Add(new Games(3, "Legend of Zelda: Breath of the Wild", "Nintendo Wii", "Puzzles", true));

            return returnList;
        }

        #endregion


    }

}
