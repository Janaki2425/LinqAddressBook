using System;
namespace AddressBookLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book ");

            List<AddressDetails> myList = new List<AddressDetails>();
            myList.Add(new AddressDetails("Sri", "vatson", "9887523256", "3-12", "Chennai", "600026", "Tamilnadu", "abc@gmail.com"));
            myList.Add(new AddressDetails("Hari", "prasad", "9889993256", "4-12", "Chennai", "600019", "Tamilnadu", "ac@gmail.com"));
            myList.Add(new AddressDetails("Priya", "sri", "8087523256", "3-98", "Bangalore", "800906", "Karnataka", "bc@gmail.com"));
            myList.Add(new AddressDetails("Bob", "noble", "9800523256", "77-12", "Mysore", "800026", "Karnataka", "oun@gmail.com"));
            myList.Add(new AddressDetails("Vikram", "singh", "9887000256", "03-12", "Hyderabad", "900026", "Andhra pradesh", "abchh@gmail.com"));
            myList.Add(new AddressDetails("prakash", "poorvi", "9887522346", "78-92", "Chennai", "600134", "Tamilnadu", "jsg@gmail.com"));
            myList.Add(new AddressDetails("Naga", "chaitanya", "9887599956", "3-1200", "Hyderabad", "608826", "Andhra pradesh", "abcu@gmail.com"));
            myList.Add(new AddressDetails("Saravana", "kumar", "9887508756", "367-12", "Chennai", "698026", "Tamilnadu", "abcavc@gmail.com"));
            myList.Add(new AddressDetails("Angelina", "grace", "7087523256", "31-12", "Kolkata", "900026", "WestBengal", "abooc@gmail.com"));

            //uc2
            foreach (var address in myList)
            {
                if (address.FirstName == "Vikram")
                {
                    address.State = "WestBengal";

                }
            }
            foreach (var list in myList)
            {
                Console.WriteLine("FirstName:" + list.FirstName + " " + "LastName:" + list.LastName + " " + "Address:" + list.Address + " " + "PhoneNumber:" + list.PhoneNumber + " " + "City:" + list.City + " " + "State:" + list.State + " " + "ZIP:" + list.ZIP + " " + "Email:" + list.Email);
            }


            //uc3
            foreach (var address in myList)
            {
                if (address.FirstName == "Priya")
                {
                    address.Delete();

                }
            }
            foreach (var list in myList)
            {
                Console.WriteLine("FirstName:" + list.FirstName + " " + "LastName:" + list.LastName + " " + "Address:" + list.Address + " " + "PhoneNumber:" + list.PhoneNumber + " " + "City:" + list.City + " " + "State:" + list.State + " " + "ZIP:" + list.ZIP + " " + "Email:" + list.Email);
            }
            Retrieve.RetrieveRecord(myList);
            Retrieve.Count(myList);
            Sort.SortingAlphabetically(myList);
           
        }
    }
}




        


    
    




            




        



    


