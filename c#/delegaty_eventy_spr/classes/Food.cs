namespace Classes;

public class Food
{
    public string Name { get; set; }
    public int Calories { get; set; }

    public Food(string name, int calories)
    {
        Name = name; Calories = calories;
    }

    public void PrintInfo() { Console.WriteLine($"Jedzenie {Name} ma {Calories} kalorii."); }
}