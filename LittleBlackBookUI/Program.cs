using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace LittleBlackBookUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opening your Little Black Book...\n");

            UserMenu();
            UserResponse();
        }

        private static void UserResponse()
        {
            int userResponse = int.Parse(Console.ReadLine());

            switch (userResponse)
            {
                case 1:
                    Contact c = new Contact();

                    Console.WriteLine("Please enter the contacts first name.");
                    c.FirstName = Console.ReadLine();

                    Console.WriteLine("Please enter the contacts last name.");
                    c.LastName = Console.ReadLine();

                    Console.WriteLine("Please enter the contacts phone number.");
                    c.PhoneNumber = Console.ReadLine();

                    PhoneBook.ContactList.Add(c);

                    UserMenu();
                    UserResponse();

                    break;


                case 2:
                    Console.WriteLine("Here are the contacts you have: \n");
                    foreach (var contact in PhoneBook.ContactList)

                    Console.WriteLine($"Name: {contact.FirstName } {contact.LastName}| Phonenumber: {contact.PhoneNumber}");

                    UserMenu();
                    UserResponse();

                    break;

                case 3:
                    Console.WriteLine("Who would you like to update?");

                    var userUpdate = Console.ReadLine();
                    for (int i = 0; i < PhoneBook.ContactList.Count; i++)
                    {
                        if (PhoneBook.ContactList[i].FirstName == userUpdate)
                        {
                            PhoneBook.ContactList.Remove(PhoneBook.ContactList[i]);
                        }
                    }

                    Contact u = new Contact();
                    
                    Console.WriteLine("Please enter the contacts first name.");
                    u.FirstName = Console.ReadLine();

                    Console.WriteLine("Please enter the contacts last name.");
                    u.LastName = Console.ReadLine();

                    Console.WriteLine("Please enter the contacts phone number.");
                    u.PhoneNumber = Console.ReadLine();

                    PhoneBook.ContactList.Add(u);

                    UserMenu();
                    UserResponse();

                    break;

                case 4:
                    Console.WriteLine("Adios to who?");

                    var userRemove = Console.ReadLine();
                    for (int i = 0; i < PhoneBook.ContactList.Count; i++)
                    {
                        if (PhoneBook.ContactList[i].FirstName == userRemove)
                        {
                            PhoneBook.ContactList.Remove(PhoneBook.ContactList[i]);
                        }
                    }

                    UserMenu();
                    UserResponse();

                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    break;

            }
        }

        public static void UserMenu()
        {
            Console.WriteLine("\nWhat would you like to do?\n" +
            "1 - Create a new contact\n" +
            "2 - View your contacts\n" +
            "3 - Update a contact\n" +
            "4 - Get rid of someone\n" +
            "5 - Exit\n");
        }
    }


}
