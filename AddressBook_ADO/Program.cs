// See https://aka.ms/new-console-template for more information
using AddressBook_ADO;

Console.WriteLine("Welcome To AddressBook Data Base Program!");
AddressBookRepo repo = new AddressBookRepo();
AddressBookModel enter = new AddressBookModel();
repo.GetDetails();