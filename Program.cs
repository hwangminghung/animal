using System;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Speak()
    {
        Console.WriteLine("The animal makes a sound");
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Cat : Animal
{
    public string Color { get; set; }

    public Cat(string name, int age, string color) : base(name, age)
    {
        Color = color;
    }

    public void Meow()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("Tom", 3, "Black");
        cat.DisplayInfo();
        cat.Meow();

        Console.WriteLine();

        Animal animal = new Animal("Lion", 5);
        animal.DisplayInfo();
        animal.Speak();
    }
}