using System;
using System.Collections.Generic;

//ADD THE ANIMALS
enum AnimalType
{
    Mammal,
    Bird,
    Reptile,
    
}
enum FoodType
{
    Meat,
    Vegetation,
    Mixed,
    
}
enum HabitatType
{
    Desert,
    Forest,
    Aquatic,
    
}

struct DietInfo
{
    public string DietaryRequirements;
    public string FeedingSchedule;
}



//ANIMAL ACTIONS 
abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void Eat();
    public abstract void Move();
    public abstract void Speak();
}

interface IClimbable
{
    void Climb();
}
interface ISwimmable
{
    void Swim();
}
interface IFlyable
{
    void Fly();
}



class Lion : Animal, IClimbable
{
    public Lion(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Lion is eating meat..."); }
    public override void Move() { Console.WriteLine("Lion is running..."); }
    public override void Speak() { Console.WriteLine("Lion roars..."); }
    public void Climb() { Console.WriteLine("Lion climbs..."); }
}






class Parrot : Animal, IFlyable
{
    public Parrot(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Parrot is eating seeds..."); }
    public override void Move() { Console.WriteLine("Parrot is flying..."); }
    public override void Speak() { Console.WriteLine("Parrot chirps..."); }
    public void Fly() { Console.WriteLine("Parrot flies..."); }
}
class Elephant : Animal
{
    public Elephant(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Elephant is eating vegetation..."); }
    public override void Move() { Console.WriteLine("Elephant is walking..."); }
    public override void Speak() { Console.WriteLine("Elephant trumpets..."); }
}
class Crocodile : Animal, ISwimmable
{
    public Crocodile(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Crocodile is eating meat..."); }
    public override void Move() { Console.WriteLine("Crocodile is swimming..."); }
    public override void Speak() { Console.WriteLine("Crocodile hisses..."); }
    public void Swim() { Console.WriteLine("Crocodile swims..."); }
}
class Eagle : Animal, IFlyable
{
    public Eagle(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Eagle is eating meat..."); }
    public override void Move() { Console.WriteLine("Eagle is flying..."); }
    public override void Speak() { Console.WriteLine("Eagle screeches..."); }
    public void Fly() { Console.WriteLine("Eagle flies..."); }
}
class Tiger : Animal, IClimbable
{
    public Tiger(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Tiger is eating meat..."); }
    public override void Move() { Console.WriteLine("Tiger is walking..."); }
    public override void Speak() { Console.WriteLine("Tiger roars..."); }
    public void Climb() { Console.WriteLine("Tiger climbs..."); }
}
class Giraffe : Animal
{
    public Giraffe(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Giraffe is eating leaves..."); }
    public override void Move() { Console.WriteLine("Giraffe is walking..."); }
    public override void Speak() { Console.WriteLine("Giraffe bleats..."); }
}
class Snake : Animal
{
    public Snake(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Snake is eating rodents..."); }
    public override void Move() { Console.WriteLine("Snake is slithering..."); }
    public override void Speak() { Console.WriteLine("Snake hisses..."); }
}

class Zoo
{
    private List<Animal> animals = new List<Animal>();
    public Zoo()
    {
        animals.Add(new Lion("Simba", 5));
        animals.Add(new Parrot("Polly", 3));
        animals.Add(new Elephant("Dumbo", 10));
        animals.Add(new Tiger("Shere Khan", 8));
        animals.Add(new Giraffe("Melman", 7));
        animals.Add(new Snake("Kaa", 6));
    }
    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }
    public void DisplayAnimals()
    {
        Console.WriteLine("Animals in the zoo:");
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Type: {animal.GetType().Name}, Age: {animal.Age}");
        }
    }
    public void FeedAnimal(int index)
    {
        if (index >= 0 && index < animals.Count)
        {
            animals[index].Eat();
        }
        else
        {
            Console.WriteLine("Invalid animal index!");
        }
    }
    public void MakeAnimalSleep(int index)
    {
        if (index >= 0 && index < animals.Count)
        {
            Console.WriteLine($"{animals[index].Name} is sleeping...");
        }
        else
        {
            Console.WriteLine("Invalid animal index!");
        }
    }
}
class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Zoo Management System");
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. Display Animals");
            Console.WriteLine("3. Feed Animal");
            Console.WriteLine("4. Make Animal Sleep");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter animal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter animal age: ");
                        int age;
                        if (int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine("Select animal type:");
                            Console.WriteLine("1. Lion");
                            Console.WriteLine("2. Parrot");
                            Console.WriteLine("3. Elephant");
                            Console.WriteLine("4. Crocodile");
                            Console.WriteLine("5. Eagle");
                            Console.WriteLine("6. Tiger");
                            Console.WriteLine("7. Giraffe");
                            Console.WriteLine("8. Snake");
                            Console.Write("Enter choice: ");
                            int typeChoice;
                            if (int.TryParse(Console.ReadLine(), out typeChoice))
                            {
                                Animal animal;
                                switch (typeChoice)
                                {
                                    case 1:
                                        animal = new Lion(name, age);
                                        break;
                                    case 2:
                                        animal = new Parrot(name, age);
                                        break;
                                    case 3:
                                        animal = new Elephant(name, age);
                                        break;
                                    case 4:
                                        animal = new Crocodile(name, age);
                                        break;
                                    case 5:
                                        animal = new Eagle(name, age);
                                        break;
                                    case 6:
                                        animal = new Tiger(name, age);
                                        break;
                                    case 7:
                                        animal = new Giraffe(name, age);
                                        break;
                                    case 8:
                                        animal = new Snake(name, age);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid choice!");
                                        continue;
                                }
                                zoo.AddAnimal(animal);
                                Console.WriteLine("Animal added successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid age!");
                        }
                        break;
                    case 2:
                        zoo.DisplayAnimals();
                        break;
                    case 3:
                        Console.Write("Enter index of the animal to feed: ");
                        int feedIndex;
                        if (int.TryParse(Console.ReadLine(), out feedIndex))
                        {
                            zoo.FeedAnimal(feedIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index!");
                        }
                        break;
                    case 4:
                        Console.Write("Enter index of the animal to make sleep: ");
                        int sleepIndex;
                        if (int.TryParse(Console.ReadLine(), out sleepIndex))
                        {
                            zoo.MakeAnimalSleep(sleepIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index!");
                        }
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
            Console.WriteLine();
        }
    }
}