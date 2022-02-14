using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    internal class AddNewColumn
    {

        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string phonenumber;
        private string zip;
        private string state;
        private string email;
        private string type;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public AddNewColumn(string firstname, string lastname, string address, string city, string phonenumber, string zip, string state, string email, string type)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            City = city;
            State = state;
            Email = email;
            PhoneNumber = phonenumber;
            ZIP = zip;
            Type = type;
        }

        static void Main(string[] args)
        {
            List<AddNewColumn> otherList = new List<AddNewColumn>();

            otherList.Add(new AddNewColumn("Sri", "vatson", "9887523256", "3-12", "Chennai", "600026", "Tamilnadu", "abc@gmail.com","Family"));
            otherList.Add(new AddNewColumn("Hari", "prasad", "9889993256", "4-12", "Chennai", "600019", "Tamilnadu", "ac@gmail.com","Friend"));
            otherList.Add(new AddNewColumn("Priya", "sri", "8087523256", "3-98", "Bangalore", "800906", "Karnataka", "bc@gmail.com","Friend"));
            otherList.Add(new AddNewColumn("Bob", "noble", "9800523256", "77-12", "Mysore", "800026", "Karnataka", "oun@gmail.com","Profession"));
            otherList.Add(new AddNewColumn("Vikram", "singh", "9887000256", "03-12", "Hyderabad", "900026", "Andhra pradesh", "abchh@gmail.com","Family"));
            otherList.Add(new AddNewColumn("Prakash", "poorvi", "9887522346", "78-92", "Chennai", "600134", "Tamilnadu", "jsg@gmail.com","Friend"));
            otherList.Add(new AddNewColumn("Naga", "chaitanya", "9887599956", "3-1200", "Hyderabad", "608826", "Andhra pradesh", "abcu@gmail.com","Profession"));
            otherList.Add(new AddNewColumn("Saravana", "kumar", "9887508756", "367-12", "Chennai", "698026", "Tamilnadu", "abcavc@gmail.com","Family"));
            otherList.Add(new AddNewColumn("Angelina", "grace", "7087523256", "31-12", "Kolkata", "900026", "WestBengal", "abooc@gmail.com","Family"));

            foreach (var list in otherList)
            {
                Console.WriteLine("FirstName:" + list.FirstName + " " + "LastName:" + list.LastName + " " + "Address:" + list.Address + " " + "PhoneNumber:" + list.PhoneNumber + " " + "City:" + list.City + " " + "State:" + list.State + " " + "ZIP:" + list.ZIP + " " + "Email:" + list.Email);
            }
        }


    }
}
