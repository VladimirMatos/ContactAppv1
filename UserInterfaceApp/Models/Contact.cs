using System;
using System.Collections.Generic;
using System.Text;

namespace UserInterfaceApp
{
    public class Contact
    {
        public int Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PictureUrl { get; set; }

        public Contact(int phone, string firstName, string lastname , string pictureUrl)
        {
            Phone = phone;
            FirstName = firstName;
            LastName = lastname;
           
        }

        public Contact()
        {
        }
    }
}
