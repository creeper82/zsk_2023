namespace Program;

public static class Menu
{
    private static List<Person> users = [];

    public static void DisplayMenu()
    {

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Użytkownicy");
            DisplayUsers();
            Console.WriteLine();

            Console.WriteLine(
                "1. Dodaj użytkownika\n" +
                "2. Usuń wszystkich użytkowników\n" +
                "3. Wyjście"
            );

            running = HandleKey();
        }

    }

    public static void DisplayUsers()
    {
        foreach (Person person in users) Console.WriteLine(person.GetFullName());
    }

    private static bool HandleKey()
    {
        ConsoleKey key = Console.ReadKey(true).Key;

        switch (key)
        {
            case ConsoleKey.D1:
                AddUser();
                break;
            case ConsoleKey.D2:
                ClearUsers();
                break;
            case ConsoleKey.D3:
                return false;
        }

        return true;
    }

    private static void AddUser()
    {
        string firstName = Prompt("Podaj imię");
        string lastName = Prompt("Podaj nazwisko");
        int year = NumberPrompt("Podaj rok urodzenia");
        int month = NumberPrompt("Podaj miesiąc urodzenia");
        int day = NumberPrompt("Podaj dzień urodzenia");
        string city = Prompt("Podaj miasto");
        string houseNum = Prompt("Podaj numer domu");
        string postalCode = Prompt("Podaj kod pocztowy");

        Person newUser = new(
            firstName,
            lastName,
            new(year, month, day),
            new(city, houseNum, postalCode)
        );

        users.Add(newUser);
    }

    private static void ClearUsers() { users.Clear(); }

    private static string Prompt(string prompt)
    {
        string? input = null;

        do
        {
            Console.Write($"{prompt}: ");
            input = Console.ReadLine()?.Trim();
        } while (input is null || input == "");

        return input;
    }

    public static int NumberPrompt(string prompt)
    {
        string? input = null;
        int inputToInt = 0;

        do
        {
            Console.WriteLine($"{prompt}: ");
            input = Console.ReadLine();
        } while (!int.TryParse(input, out inputToInt));

        return inputToInt;
    }
}