// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookRepository.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBookProblemLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    public class AddressBookRepository
    {
        /// <summary>
        /// List to store the instances of address book model or records of address book
        /// </summary>
        public static List<AddressBookModel> addressBookModels = new List<AddressBookModel>();
        /// <summary>
        /// Creating the instance of the Address Book Model Class
        /// </summary>
        public AddressBookModel bookModel = new AddressBookModel();
        /// <summary>
        /// Parameterised constructor intended to add the data to the DB Model
        /// </summary>
        public AddressBookRepository()
        {
            /// Inserting the data into the list using add operation
            addressBookModels.Add(new AddressBookModel { firstName = "Raj", secondName = "Sharma", address = "Sec-1", city = "Delhi", state = "Delhi", zip = 110245, phoneNumber = 9895656235, emailId = "raj@gmail.com", contactType = "Friends", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Divya", secondName = "Raj", address = "Sec-2", city = "Faridabad", state = "Haryana", zip = 110022, phoneNumber = 9789556235, emailId = "divya@gmail.com", contactType = "Family", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Vaivaswat", secondName = "Tiwari", address = "Sec-3", city = "Kanpur", state = "UP", zip = 256123, phoneNumber = 7895656235, emailId = "vaiva@gmail.com", contactType = "Profession", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Shivam", secondName = "Rajput", address = "Sec-4", city = "Gorakhpur", state = "UP", zip = 274365, phoneNumber = 9963656235, emailId = "shivam@gmail.com", contactType = "Family", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Tarun", secondName = "Arora", address = "Sec-4", city = "Delhi", state = "Delhi", zip = 116445, phoneNumber = 7206656235, emailId = "tarun@gmail.com", contactType = "Friends", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Archana", secondName = "Upadhyay", address = "Sec-3", city = "Gorakhpur", state = "UP", zip = 274304, phoneNumber = 9450656235, emailId = "arhana@gmail.com", contactType = "Family", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Vijay", secondName = "Upadhyay", address = "Sec-8", city = "Chandigarh", state = "Punjab", zip = 160030, phoneNumber = 7645656235, emailId = "vijay@gmail.com", contactType = "Family", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Tia", secondName = "Sharma", address = "Sec-7", city = "Delhi", state = "Delhi", zip = 110235, phoneNumber = 9658741200, emailId = "tia@gmail.com", contactType = "Friends", addressBookName = "PraveenRecord" });
        }
        /// <summary>
        /// Method to add more ocntacts later
        /// </summary>
        public void AddMoreContacts()
        {
            Console.WriteLine("Enter the First Name :");
            bookModel.firstName = Console.ReadLine();
            Console.WriteLine("Enter the Second Name :");
            bookModel.secondName = Console.ReadLine();
            Console.WriteLine("Enter the Address :");
            bookModel.address = Console.ReadLine();
            Console.WriteLine("Enter the City :");
            bookModel.city = Console.ReadLine();
            Console.WriteLine("Enter the State :");
            bookModel.state = Console.ReadLine();
            Console.WriteLine("Enter the Zip :");
            bookModel.zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Phone Number :");
            bookModel.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the email-id :");
            bookModel.emailId = Console.ReadLine();
            Console.WriteLine("Enter the contact type :");
            bookModel.contactType = Console.ReadLine();
            Console.WriteLine("Enter the address book name :");
            bookModel.addressBookName = Console.ReadLine();

            addressBookModels.Add(bookModel);
        }
        /// <summary>
        /// UC5 -- Get the contact detail by the city name or state name
        /// </summary>
        public void GetContactUsingCityOrStateName()
        {
            Console.WriteLine("Enter the choice you want to retrieve data ===>");
            Console.WriteLine("1.City.");
            Console.WriteLine("2.State.");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of City or State by which you want the data -");
            string cityOrState = Console.ReadLine();
            if (choice == 1)
            {
                /// Query to implement the retrieval of the data from the address book based on city
                var matchedRecord = from record in addressBookModels.AsEnumerable()
                                    where record.city == cityOrState
                                    select record;
                /// Printing the retrieved data
                foreach (var record in matchedRecord)
                {
                    Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.secondName}\n" +
                                    $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                    $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
                    Console.WriteLine("\n \n");
                }
            }
            else
            {
                /// Query to implement the retrieval of the data from the address book based on state
                var matchedRecord = from record in addressBookModels.AsEnumerable()
                                    where record.state == cityOrState
                                    select record;
                /// Printing the retrieved data
                foreach (var record in matchedRecord)
                {
                    Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.secondName}\n" +
                                    $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                    $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
                    Console.WriteLine("\n \n");
                }
            }
        }
        /// <summary>
        /// UC6 -- Get the count of number of contacts as per the state or city
        /// </summary>
        public void GetCountByCityOrState()
        {
            Console.WriteLine("========================CountByCity========================");
            ///Query to get number of contact details grouped by same city name
            var countAsPerCity = (from records in addressBookModels.AsEnumerable()
                                  group records by records.city into Group
                                  select new { City = Group.Key, NumberOfContacts = Group.Count() });
            /// Iterating over the entire stored value with count and city
            /// Displaying the reviews count
            foreach (var record in countAsPerCity)
            {
                Console.WriteLine($"City : {record.City}, Number Of Contacts : {record.NumberOfContacts}");
            }
            Console.WriteLine("========================CountByState========================");
            ///Query to get number of contact details grouped by same state name
            var countAsPerState = (from records in addressBookModels.AsEnumerable()
                                   group records by records.state into Group
                                   select new { State = Group.Key, NumberOfContacts = Group.Count() });
            /// Iterating over the entire stored value with count and city
            /// Displaying the reviews count
            foreach (var record in countAsPerState)
            {
                Console.WriteLine($"State : {record.State}, Number Of Contacts : {record.NumberOfContacts}");
            }
        }
        /// <summary>
        /// UC7 -- Sort the data base model alphabetically by the name for a particular city
        /// </summary>
        public void SortedDetailsAlphabeticallyByNameForACity()
        {
            Console.WriteLine("Enter the name of City by which you want to sort the data alphabetically by name -");
            string city = Console.ReadLine();
            ///Query to get the sorted order of name for a particualr city
            var sortByName = (from record in addressBookModels.AsEnumerable()
                              orderby record.firstName
                              where (record.city == city)
                              select record);
            /// Iterating over the entire list
            /// Displaying the contact details
            foreach (var record in sortByName)
            {
                Console.WriteLine($"First Name:{record.firstName}\nSecond Name:{record.secondName}\n" +
                                $"Address:{record.address}, City:{record.city}, State:{record.state} PinCode: {record.zip}\n" +
                                $"Phone Number: {record.phoneNumber}\nContact Type: {record.contactType}\nAddress Book Name : {record.addressBookName}");
                Console.WriteLine("\n \n");
            }

        }
        /// <summary>
        /// UC8 -- Display the contact count grouped by contact type for the address book
        /// </summary>
        public void DisplayCountOfContactAsPerContactType()
        {
            Console.WriteLine("========================CountByContactType========================");
            ///Query to get number of contact details grouped by contact type
            var countAsPerCity = (from records in addressBookModels.AsEnumerable()
                                  group records by records.contactType into Group
                                  select new { ContactType = Group.Key, NumberOfContacts = Group.Count() });
            /// Iterating over the entire stored value with count and contact type
            /// Displaying the reviews count
            foreach (var record in countAsPerCity)
            {
                Console.WriteLine($"City : {record.ContactType}, Number Of Contacts : {record.NumberOfContacts}");
            }
        }
    }
}
