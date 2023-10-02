using System;

class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }
}

class Converter
{
    private double USD { get; set; }
    private double EUR { get; set; }
    private double PLN { get; set; }

    public Converter(double usd, double eur, double pln)
    {
        USD = usd;
        EUR = eur;
        PLN = pln;
    }

    public double UahToUsd(double amount)
    {
        return amount / USD;
    }

    public double UahToEur(double amount)
    {
        return amount / EUR;
    }

    public double UahToPln(double amount)
    {
        return amount / PLN;
    }

    public double UsdToUah(double amount)
    {
        return amount * USD;
    }

    public double EurToUah(double amount)
    {
        return amount * EUR;
    }

    public double PlnToUah(double amount)
    {
        return amount * PLN;
    }
}

class Employee
{
    public string LastName { get; set; }
    public string FirstName { get; set; }

    public Employee(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    public double CalculateSalary(string position, int experience)
    {
        // Додайте логіку для розрахунку окладу відповідно до посади та стажу тут
        return 0; // Замініть 0 на розрахований оклад
    }

    public double CalculateTax(double salary)
    {
        // Додайте логіку для розрахунку податкового збору тут
        return 0; // Замініть 0 на розрахований податковий збір
    }
}

class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Логін: {Login}");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Вік: {Age}");
        Console.WriteLine($"Дата заповнення анкети: {RegistrationDate}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address
        {
            Index = "04000",
            Country = "Україна",
            City = "Київ",
            Street = "Вулиця Матеюка",
            House = "4",
            Apartment = "9"
        };

        Console.WriteLine("Адреса:");
        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");

        Converter converter = new Converter(36.0, 39.0, 9.0);
        double amountInUah = 1000;
        Console.WriteLine($"{amountInUah} гривень в USD: {converter.UahToUsd(amountInUah)}");
        Console.WriteLine($"{amountInUah} гривень в EUR: {converter.UahToEur(amountInUah)}");
        Console.WriteLine($"{amountInUah} гривень в PLN: {converter.UahToPln(amountInUah)}");

        Employee employee = new Employee("Гузь", "Богдан");
        string position = "Менеджер";
        int experience = 5;
        double salary = employee.CalculateSalary(position, experience);
        double tax = employee.CalculateTax(salary);

        Console.WriteLine("Інформація про співробітника:");
        Console.WriteLine($"Прізвище: {employee.LastName}");
        Console.WriteLine($"Ім'я: {employee.FirstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {salary}");
        Console.WriteLine($"Податковий збір: {tax}");

        User user = new User("bohdan04", "Богдан", "Гузь", 18);
        user.DisplayInfo();
    }
}