using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    internal class Retrieve
    {
        public static void RetrieveRecord(List<AddressDetails> myList)
        {
            foreach (var address in myList)
            {
                if (address.City == "Chennai")
                {

                    foreach (var list in myList)
                    {
                        Console.WriteLine("FirstName:" + list.FirstName + " " + "LastName:" + list.LastName + " " + "Address:" + list.Address + " " + "PhoneNumber:" + list.PhoneNumber + " " + "City:" + list.City + " " + "State:" + list.State + " " + "ZIP:" + list.ZIP + " " + "Email:" + list.Email);
                    }
                }
            }
        }
        public static void Count(List<AddressDetails> myList)
        {
            foreach (var address in myList)
            {
                if (address.City.Length != 0 || address.State.Length != 0)
                {

                    foreach (var list in myList)
                    {
                        Console.WriteLine("FirstName:" + list.FirstName + " " + "LastName:" + list.LastName + " " + "Address:" + list.Address + " " + "PhoneNumber:" + list.PhoneNumber + " " + "City:" + list.City + " " + "State:" + list.State + " " + "ZIP:" + list.ZIP + " " + "Email:" + list.Email);
                    }
                }
            }
        }
    }
}


                
            
    

        
    

