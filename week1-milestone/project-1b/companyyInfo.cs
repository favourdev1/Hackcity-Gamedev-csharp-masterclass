using System;

class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public string WebSite { get; set; }
    public Manager Manager { get; set; }
}

class Manager
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Company company = new Company();
        Manager manager = new Manager();

        Console.WriteLine("Enter company information:");
        Console.Write("Name: ");
        company.Name = Console.ReadLine();
        Console.Write("Address: ");
        company.Address = Console.ReadLine();
        Console.Write("Phone number: ");
        company.PhoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        company.FaxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        company.WebSite = Console.ReadLine();
Console.Clear();
        Console.WriteLine("Enter manager information:");
        Console.Write("First name: ");
        manager.FirstName = Console.ReadLine();
        Console.Write("Last name: ");
        manager.LastName = Console.ReadLine();
        Console.Write("Age: ");
        manager.Age = int.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        manager.PhoneNumber = Console.ReadLine();
Console.Clear();
        company.Manager = manager;

        Console.WriteLine("Company Information:");
        Console.WriteLine("Name: " + company.Name);
        Console.WriteLine("Address: " + company.Address);
        Console.WriteLine("Phone number: " + company.PhoneNumber);
        Console.WriteLine("Fax number: " + company.FaxNumber);
        Console.WriteLine("Web site: " + company.WebSite);
        Console.WriteLine("Manager Information:");
        Console.WriteLine("Name: " + company.Manager.FirstName + " " + company.Manager.LastName);
        Console.WriteLine("Age: " + company.Manager.Age);
        Console.WriteLine("Phone number: " + company.Manager.PhoneNumber);
    }
}
