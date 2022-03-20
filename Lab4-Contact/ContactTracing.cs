#region Class Created by:
/*
 * Author:          Martin Barber
 * Date:            March 13th, 2022
 * Student ID:      100368442
 * Title: NETD:     Lab 4: Contact Tracing
 * File:            Contact Tracing Class page
 * https://github.com/Ritz-Bitz13/NETD2022_WInter2022_04
 */
#endregion

#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Lab4_Contact
{
    class ContactTracing
    {
        #region Class
        public int Count { get; set; }
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public Boolean Contacted { get; set; }
        public DateTime Date { get; set; }
        #endregion

        #region Constructor
        public ContactTracing() { }

       
        /// <summary>
        /// This will input all the variables for the Patients
        /// </summary>
        /// <param name="firstName">Enter the First name</param>
        /// <param name="lastName">Enter the Last name</param>
        /// <param name="date"></param>
        /// <param name="email">Enter the users Email</param>
        /// <param name="phone">Enter the Users phone Number</param>
        /// <param name="contact">Were they contacted and notified</param>
        /// <param name="count"></param>
        /// <param name="id"></param>
        public ContactTracing(String firstName, String lastName, DateTime date, String email, String phone, Boolean contact, int count, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Date = date;
            Email = email;
            Phone = phone;
            Contacted = contact;
            Count = count;
            ID = id;
        }
        #endregion

        #region Methods (Do Stuff)

        #region Static Methods
        /// <summary>
        /// This gives 3 default clients to show the Grid is working properly
        /// </summary>
        /// <returns></returns>
        public static List<ContactTracing> GetSampleContacts()
        {
            List<ContactTracing> returnList = new List<ContactTracing>();

            returnList.Add(new ContactTracing("Martin", "Barber", DateTime.Now, "martin.barber13@hotmail.com", "9055551234", true, 1, 1 ));
            returnList.Add(new ContactTracing("Gillian", "Young", DateTime.Now, "gillian.young@gmail.com", "9053125995", true, 2, 2));
            returnList.Add(new ContactTracing("Thomas", "Jackel", DateTime.Now, "thomas.jackel123@hotmail.com", "4167679173", false,3,3));

            return returnList;
        }

        public static ContactTracing GetStatus(List<ContactTracing> inputContact, int ID)
        {
            return inputContact.Find(c => c.ID == ID);
        }

        #endregion

        #endregion
    }
}

