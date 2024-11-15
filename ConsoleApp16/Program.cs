using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> persons = new List<Person>()
        {
            new Person(){ Name = "Andrey", Age = 24, City = "Kyiv"},
            new Person(){ Name = "Liza", Age = 18, City = "Odesa" },
            new Person(){ Name = "Oleg", Age = 15, City = "London" },
            new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
            new Person(){ Name = "Sergey", Age = 32, City = "Lviv" }
        };

        // 1 Люди старше 25 лет
        var olderThan25 = persons.Where(p => p.Age > 25);
        Console.WriteLine("Люди старше 25 лет:");
        foreach (var person in olderThan25)
            Console.WriteLine($"{person.Name}, {person.Age}, {person.City}");

        // 2 Люди, проживающие не в Лондоне
        var notInLondon = persons.Where(p => p.City != "London");
        Console.WriteLine("\nЛюди, проживающие не в Лондоне:");
        foreach (var person in notInLondon)
            Console.WriteLine($"{person.Name}, {person.Age}, {person.City}");

        // 3 Имена людей, проживающих в Киеве
        var namesInKyiv = persons.Where(p => p.City == "Kyiv").Select(p => p.Name);
        Console.WriteLine("\nИмена людей, проживающих в Киеве:");
        foreach (var name in namesInKyiv)
            Console.WriteLine(name);

        // 4 Люди старше 35 лет с именем Sergey
        var sergeyOlderThan35 = persons.Where(p => p.Name == "Sergey" && p.Age > 35);
        Console.WriteLine("\nЛюди старше 35 лет с именем Sergey:");
        foreach (var person in sergeyOlderThan35)
            Console.WriteLine($"{person.Name}, {person.Age}, {person.City}");

        // 5) Люди, проживающие в Одессе
        var inOdesa = persons.Where(p => p.City == "Odesa");
        Console.WriteLine("\nЛюди, проживающие в Одессе:");
        foreach (var person in inOdesa)
            Console.WriteLine($"{person.Name}, {person.Age}, {person.City}");
    }
}
