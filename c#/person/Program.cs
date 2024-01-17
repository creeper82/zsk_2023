namespace Program;

public class Program
{
    public static void Main()
    {
        Address a1 = new("Warszawa", "Fredry 15", "12-345");

        Person p1 = new(
            "Jan",
            "Kowalski",
            new(2006, 01, 01),
            a1
        );

        Student s1 = new(
            "Krystyna",
            "Nowak",
            new(2006, 01, 01),
            a1,
            2136
        );

        Teacher t1 = new(
            "Alicja",
            "Słotwińska",
            new(1983, 04, 13),
            a1,
            ["matma", "polski"]
        );

        Console.WriteLine(p1.GetFullName());
        Console.WriteLine(p1.Age);

        Console.WriteLine(s1.GetFullName());
        Console.WriteLine(t1.GetFullName());
        Console.WriteLine(t1.Age);
    }
}

