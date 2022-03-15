using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Contact
{
    class ContactTracing
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public Boolean Contacted { get; set; }

        #region Constructor
        public ContactTracing() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName">Enter The Contacts first name</param>
        /// <param name="lastName">Enter contacts last name</param>
        /// <param name="email">enter their email address</param>
        /// <param name="phone">enter their phone number</param>
        /// <param name="contact">Were they contacted? true or false</param>
        public ContactTracing(String firstName, String lastName, String email, String phone, Boolean contact)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Contacted = contact;
        }
        #endregion

        #region Methods (Do Stuff)

        #region Custom Method

        #endregion

        #region Static Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ContactTracing> GetSampleContacts()
        {
            List<ContactTracing> returnList = new List<ContactTracing>();

            returnList.Add(new ContactTracing("Martin", "Barber", "martin.barber13@hotmail.com", "905-555-1234", true));
            returnList.Add(new ContactTracing("Gillian", "Young", "gillian.young@gmail.com", "905-312-5995", true));
            returnList.Add(new ContactTracing("Thomas", "Jackel", "thomas.jackel123@hotmail.com", "416-767-9173", false));

            return returnList;
        }
        #endregion

        #endregion
    }
}

