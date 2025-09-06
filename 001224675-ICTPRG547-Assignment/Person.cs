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
        /// <summary>
        /// Getters and setters for all parameters
        /// </summary>
        public string PersonName { get; set; }
        public string PersonEmail { get; set; }
        public string PersonPhoneNumber { get; set; }
        public Address PersonAddress { get; set; }
        /// <summary>
        /// Static property to get the number of people
        /// </summary>
        public static int NumPeople
        {
            get
            {
                return numPeople;
            }
        }
        /// <summary>
        /// Constructor that takes all parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        public Person(string name, string email, string phoneNumber, Address address)
        {
            PersonName = name;
            PersonEmail = email;
            PersonPhoneNumber = phoneNumber;
            PersonAddress = address;
            numPeople++;
        }
        /// <summary>
        /// Default constructor that uses default values for all parameters
        /// </summary>
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER)
        {

        }
        /// <summary>
        /// Constructor that takes name, email and phone number and uses a default address
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        public Person(string name, string email, string phoneNumber) : this(name,email,phoneNumber,new Address())
        {

        }
        /// <summary>
        /// Override of the ToString method to display all parameters of the person
        /// </summary>
        /// <returns>the string that was created</returns>
        public override string ToString()
        {
            return "name: " + PersonName + " email: " + PersonEmail + " phoneNumber: " + PersonPhoneNumber + " address: " + PersonAddress;
        }
    }
}
