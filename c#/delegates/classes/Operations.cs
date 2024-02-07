namespace Operations;
    public static class OpsClass
    {
        

    public static int Add(int a, int b) => a + b;
    public static int Substract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static int Divide(int a, int b) => a / b;

    public static void DisplayResult(Operation operation, int a, int b)
    {
        try
        {
            int result = operation(a, b);
            Console.WriteLine($"Wynik operacji {operation.Method.Name} na liczbach {a}, {b} wynosi {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Nie można podzielić przez zero");
        }
    }

    public delegate int Operation(int a, int b);

    
}