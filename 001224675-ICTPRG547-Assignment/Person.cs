using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nathan_ICTPRG547_Assignment
{
    class Person
    {
        /*private string name;
        private string email;
        private string phoneNumber;
        private Address address;*/
        private static int numPeople;

        const string DEF_NAME = "John doe";
        const string DEF_EMAIL = "Not found";
        const string DEF_PHONE_NUMBER = "Not found";

        public string PersonName { get; set; }
        public string PersonEmail { get; set; }
        public string PersonPhoneNumber { get; set; }
        public Address PersonAddress { get; set; }

        public static int NumPeople
        {
            get
            {
                return numPeople;
            }
        }

        public Person(string name, string email, string phoneNumber, Address address)
        {
            PersonName = name;
            PersonEmail = email;
            PersonPhoneNumber = phoneNumber;
            PersonAddress = address;
            numPeople++;
        }

        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER)
        {

        }

        public Person(string name, string email, string phoneNumber) : this(name,email,phoneNumber,new Address())
        {

        }

        public override string ToString()
        {
            return "name: " + PersonName + " email: " + PersonEmail + " phoneNumber: " + PersonPhoneNumber + " address: " + PersonAddress;
        }
    }
}
