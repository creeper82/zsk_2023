namespace Input;

public static class UserInput {
    public static int GetIntFromUser(string prompt) {
        string input = "";
        int output;

        do
        {
            Console.Write($"{prompt}: ");
            input = Console.ReadLine() ?? "";
        }
        while (!int.TryParse(input, out output) || output < 0);

        return output;
    }
}