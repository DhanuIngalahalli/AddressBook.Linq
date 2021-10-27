using System;

namespace AddressBook_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Using LINQ !");
            AddressBookTable addressBookTable = new AddressBookTable();

            DataTable data = addressBookTable.CreateAddressBookDataTable();
            addressBookTable.DisplayContacts(data);
        }
    }
}