using System;
using System.Collections.Generic;

class CarShared
{
    public string Company;
    public string Model;
    public string Color;

    public CarShared(string company, string model, string color)
    {
        Company = company;
        Model = model;
        Color = color;
    }

    public void Display(string owner, string number)
    {
        Console.WriteLine($"Auto: {Color} {Company} {Model}, Besitzer: {owner}, Nummer: {number}");
    }
}

class FlyweightFactory
{
    private Dictionary<string, CarShared> flyweights = new Dictionary<string, CarShared>();

    public CarShared GetCar(string company, string model, string color)
    {
        string key = $"{company}_{model}_{color}";

        if (!flyweights.ContainsKey(key))
        {
            Console.WriteLine("Neues Flyweight erzeugt.");
            flyweights[key] = new CarShared(company, model, color);
        }
        else
        {
            Console.WriteLine("Flyweight wiederverwendet.");
        }

        return flyweights[key];
    }
}

class Program
{
    static void Main()
    {
        var factory = new FlyweightFactory();

        // Auto 1
        var car1 = factory.GetCar("BMW", "M5", "rot");
        car1.Display("James Doe", "CL234IR");

        // Auto 2 (gleiche Eigenschaften – wird wiederverwendet)
        var car2 = factory.GetCar("BMW", "M5", "rot");
        car2.Display("Anna Smith", "XY987AB");

        // Auto 3 (anderes Modell – neues Flyweight)
        var car3 = factory.GetCar("BMW", "X6", "weiß");
        car3.Display("John Miller", "ZZ112XX");
    }
}
