using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nathan_ICTPRG547_Assignment
{
    class Address
    {
        /*private int streetNum;
        private string streetName;
        private string suburb;
        private int postcode;
        private string state;*/
        private static int numAddress;

        const int DEF_STREET_NUM = 0;
        const string DEF_STREET_NAME = "Not found";
        const string DEF_SUBURB = "Not found";
        const int DEF_POSTCODE = 0;
        const string DEF_STATE = "Not found";

        public int AddressStreetNum { get; set; }
        public string AddressStreetName { get; set; }
        public string AddressSuburb { get; set; }
        public int AddressPostcode { get; set; }
        public string AddressState { get; set; }

        public static int NumAddress { 
            get { 
                return numAddress; 
            } 
        }

        public Address () : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {

        }
        public Address(int streetNum, string streetName, string suburb, int postcode, string state)
        {
            AddressStreetNum = streetNum;
            AddressStreetName = streetName;
            AddressSuburb = suburb;
            AddressPostcode = postcode;
            AddressState = state;
            numAddress++;
        }

        public override string ToString()
        {
            return "streetNum: "+ AddressStreetNum+" streetName: "+ AddressStreetName+ " suburb: "+AddressSuburb+" postcode: " +AddressPostcode+" state: "+ AddressState;
        }
    }
}
