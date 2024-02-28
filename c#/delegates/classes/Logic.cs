namespace Operations;

public static class LogicClass {
    

    public static bool And(bool a, bool b) => a && b;

    public static bool Or(bool a, bool b) => a | b;

    public static bool Not(bool a, bool b) => !a;

    public static void DisplayResult(Logic logic, bool a, bool b) {
        bool result = logic(a, b);
    }

    public delegate bool Logic(bool a, bool b);
}