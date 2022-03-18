using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE04_Classes
{
    class ContactTracing
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public Boolean Contact { get; set; }

        #region Constructor
        public ContactTracing() { }

        public ContactTracing(String firstName, String lastName, String email, String phone, Boolean contact)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Contact = contact;
        }
        #endregion

        #region Methods (Do Stuff)

        #region Custom Method

        #endregion

        #region Static Methods
        public static List<ContactTracing> GetSampleContacts()
        {
            List<ContactTracing> returnList = new List<ContactTracing>();

            returnList.Add(new ContactTracing("Martin", "Barber", "martin.barber13@hotmail.com", "9055551234", true));
            returnList.Add(new ContactTracing("Gillian", "Young", "gillian.young@gmail.ca", "9053125995", true));
            returnList.Add(new ContactTracing("Thomas", "Jackel", "thomas.jackel123@hotmail.com", "4167679173", false));

            return returnList;
        }
        #endregion

        #endregion
    }
}
