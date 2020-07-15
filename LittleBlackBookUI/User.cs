using System;
using System.Collections.Generic;
using System.Text;

namespace LittleBlackBookUI
{
    public class User
    {


        public static void ReadAllContacts()
        {
            //Reading all contacts
            foreach (var c in PhoneBook.ContactList)
            {
                Console.WriteLine($"FirstName: {c.FirstName} | LastName: {c.LastName}" +
                    $" PhoneNumber: {c.PhoneNumber}");
            }
        }

    }

}
