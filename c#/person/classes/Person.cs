namespace Program;

class Person(string imie, int wiek)
{
    public string Imie = imie;
    public int Wiek = wiek;
}

static class Data
{
    public static Person[] GetPeople(int n)
    {
        Person[] people = new Person[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Osoba #{i + 1}");

            string? imie = "";
            string? wiekStr = "";
            int wiek;

            // imie

            do
            {
                Console.Write("Podaj imię: ");
                imie = Console.ReadLine();
            } while (string.IsNullOrEmpty(imie));

            // wiek

            do
            {
                Console.Write("Podaj wiek: ");
                wiekStr = Console.ReadLine();
            } while (!int.TryParse(wiekStr, out wiek));

            people[i] = new Person(imie, wiek);
        }

        return people;
    }

    // public static void Display(this Person[] people)
    // {
    //     foreach (var person in people) Console.WriteLine($"{person.Imie}, Wiek: {person.Wiek}");
    // }
}