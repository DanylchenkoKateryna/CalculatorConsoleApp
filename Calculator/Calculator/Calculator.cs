namespace Calculator;

public static class Calculator
{

    public static void Add(int a, int b) => Console.WriteLine(a + b);

    public static void Subtract(int a, int b) => Console.WriteLine(a - b);

    public static void Multiply(int a, int b) => Console.WriteLine(a * b);

    public static void Divide(int a, int b)
    {
        try
        {
            Console.WriteLine(a / b);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Try again !");
        }
    }
}
