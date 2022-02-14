using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    internal class AddressDetails
    {
        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string phonenumber;
        private string zip;
        private string state;
        private string email;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }
        public string Email { get; set; }
        public AddressDetails(string firstname,string lastname,string address,string city,string phonenumber,string zip,string state,string email)
        {
            FirstName= firstname;
            LastName= lastname;
            Address= address;
            City= city;
            State= state;
            Email= email;
            PhoneNumber= phonenumber;
            ZIP= zip;
        }





    }
}
