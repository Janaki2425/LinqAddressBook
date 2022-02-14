using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    internal class Sort
    {
        public static void SortingAlphabetically(List<AddressDetails> myList)
        {
            var orderByResult = from m in myList
                                orderby m.FirstName
                                select m;

            foreach (var list in myList)
            {
                Console.WriteLine("FirstName:" + list.FirstName + " " + "LastName:" + list.LastName + " " + "Address:" + list.Address + " " + "PhoneNumber:" + list.PhoneNumber + " " + "City:" + list.City + " " + "State:" + list.State + " " + "ZIP:" + list.ZIP + " " + "Email:" + list.Email);
            }
        }
      
    }
}
                
            


        
