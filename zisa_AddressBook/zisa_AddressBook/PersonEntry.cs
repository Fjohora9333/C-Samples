using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zisa_AddressBook
{
    public class PersonEntry
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        //Default constructor
        public PersonEntry()
        {

        }

        //constructor wwith all the three parameters
        public PersonEntry(string name, string emailAddress, string phoneNumber)
        {
            Name = name;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }
        public override string ToString() => $"Name:{Name},EmailAddress:{EmailAddress},PhoneNumber:{PhoneNumber}";
    }
}
