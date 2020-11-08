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
    using System.Text;
    public class AddressBookRepository
    {
        /// <summary>
        /// List to store the instances of address book model or records of address book
        /// </summary>
        public static List<AddressBookModel> addressBookModels = new List<AddressBookModel>();
        /// <summary>
        /// Parameterised constructor intended to add the data to the DB Model
        /// </summary>
        public AddressBookRepository()
        {
            /// Inserting the data into the list using add operation
            addressBookModels.Add(new AddressBookModel {firstName ="Raj", secondName = "Sharma", address = "Sec-1", city = "Delhi", state = "Delhi", zip = 110245, phoneNumber = 9895656235, emailId="raj@gmail.com", contactType = "Friends", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel {firstName ="Divya", secondName = "Raj", address = "Sec-2", city = "Faridabad", state = "Haryana", zip = 110022, phoneNumber = 9789556235, emailId="divya@gmail.com", contactType = "Family", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Vaivaswat", secondName = "Tiwari", address = "Sec-3", city = "Kanpur", state = "UP", zip = 256123, phoneNumber = 7895656235, emailId = "vaiva@gmail.com", contactType = "Profession", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel {firstName ="Shivam", secondName = "Rajput", address = "Sec-4", city = "Gorakhpur", state = "UP", zip = 274365, phoneNumber = 9963656235, emailId="shivam@gmail.com", contactType = "Family", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Tarun", secondName = "Arora", address = "Sec-4", city = "Delhi", state = "Delhi", zip = 116445, phoneNumber = 7206656235, emailId = "tarun@gmail.com", contactType = "Friends", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Archana", secondName = "Upadhyay", address = "Sec-3", city = "Gorakhpur", state = "UP", zip = 274304, phoneNumber = 9450656235, emailId = "arhana@gmail.com", contactType = "Family", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Vijay", secondName = "Upadhyay", address = "Sec-8", city = "Chandigarh", state = "Punjab", zip = 160030, phoneNumber = 7645656235, emailId = "vijay@gmail.com", contactType = "Family", addressBookName = "PraveenRecord" });
            addressBookModels.Add(new AddressBookModel { firstName = "Tia", secondName = "Sharma", address = "Sec-7", city = "Delhi", state = "Delhi", zip = 110235, phoneNumber = 9658741200, emailId = "tia@gmail.com", contactType = "Friends", addressBookName = "PraveenRecord" });
        }
    }
}
