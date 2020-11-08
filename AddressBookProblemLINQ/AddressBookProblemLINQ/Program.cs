// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBookProblemLINQ
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Welcome to the Address Book Data LINQ Operartion Program");
            Console.WriteLine("========================================================");
            /// Creating the instance of the address book repository
            /// Automatically populates the list for LINQ operation
            AddressBookRepository bookRepository = new AddressBookRepository();
            /// UC5 -- To retrieve the contact of the person in the address book from a particualr state or city
            bookRepository.GetContactUsingCityOrStateName();
            /// UC6 -- To retrieve the count of the contact from the adddress book groupedby city or state
            bookRepository.GetCountByCityOrState();
        }
    }
}
