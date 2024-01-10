namespace Program;

class Program
{
    static void Main(string[] args)
    {
        string? nStr;
        int n;

        Console.Write("Podaj ilosc osob: ");

        do
        {
            nStr = Console.ReadLine();
        } while (!int.TryParse(nStr, out n));

        Person[] people = Data.GetPeople(n);

        ImionaNaLitereA(people);
        Pelnoletni(people);
    }

    static void ImionaNaLitereA(Person[] people)
    {
        Console.WriteLine("\nImiona na literę A:");

        List<string> names =
            people
                .Where(p => p.Imie.ToUpper().StartsWith('A'))
                .Select(p => p.Imie)
                .ToList();

        foreach (string name in names) Console.WriteLine(name);
    }

    static void Pelnoletni(Person[] people)
    {
        Console.WriteLine("\nPelnoletni ludzie:");

        List<Person> pelnoletni = people.Where(p => p.Wiek > 18).ToList();
        Dictionary<string, int> dict = pelnoletni.ToDictionary(p => p.Imie, p => p.Wiek);

        foreach (var elem in dict) Console.WriteLine($"Imię: {elem.Key}, Wiek: {elem.Value}");
    }
}

