// See https://aka.ms/new-console-template for more information
using AddressBook_ADO;

Console.WriteLine("Welcome To AddressBook Data Base Program!");
AddressBookRepo repo = new AddressBookRepo();
AddressBookModel enter = new AddressBookModel();
repo.GetDetails();
string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        repo.GetDetails();
        break;
    case "2":
        Console.WriteLine("Enter Type of AddressBook");
        string type = Console.ReadLine();
        Console.WriteLine("Enter AddressBookName");
        string name = Console.ReadLine();
        Console.WriteLine("Enter First Name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter Last Name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter Address");
        string address = Console.ReadLine();
        Console.WriteLine("Enter City");
        string city = Console.ReadLine();
        Console.WriteLine("Enter State");
        string state = Console.ReadLine();
        Console.WriteLine("Enter Zip");
        string zip = Console.ReadLine();
        Console.WriteLine("Enter Phone Number");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter Email");
        string email = Console.ReadLine();
        enter.Type = type;
        enter.AddressBookName = name;
        enter.FirstName = firstName;
        enter.LastName = lastName;
        enter.Address = address;
        enter.City = city;
        enter.State = state;
        enter.Zip = zip;
        enter.PhoneNumber = phoneNumber;
        enter.Email = email;
        if (repo.AddDetails(enter))
            Console.WriteLine("Details Added Successfully");
        break;
    case "x":
        return;
    default:
        Console.WriteLine("Invalid Input");
        break;
}
        repo.UpdateDetails();
        repo.Remove();
        repo.RetrievePersonByCityOrState();