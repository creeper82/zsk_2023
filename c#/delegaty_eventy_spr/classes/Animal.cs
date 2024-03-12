namespace Classes;

public class Animal
{
    public delegate void AnimalSoundHandler();

    public string Name { get; set; }
    public string Species { get; set; }
    public byte Age { get; set; }
    public event AnimalSoundHandler? AnimalSoundEvent;

    public Animal(string name, string species, byte age)
    {
        Name = name; Species = species; Age = age;
    }

    public void MakeSound() { AnimalSoundEvent?.Invoke(); }

    public void PrintInfo() { Console.WriteLine($"Zwierzę gatunku {Species} ma nazwę {Name} i wiek {Age} lat/a."); }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string breed, string name, string species, byte age) : base(name, species, age)
    {
        Breed = breed;
    }
}