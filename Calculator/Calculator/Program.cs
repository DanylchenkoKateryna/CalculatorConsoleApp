namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Calculator!");
        while (true)
        {
            Console.WriteLine("Choose operation:");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");
            Console.WriteLine("5 - Exit\n");


            string input = Console.ReadLine();

            if (input == "5")
                break;

            if (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.WriteLine("Incorrect operation");
                continue;
            }

            Console.Write("Enter first number: ");
            int number1;
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Invalid number format!");
                continue;
            }

            Console.Write("Enter second number: ");
            int number2;
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Invalid number format!\n");
                continue;
            }

            switch (input)
            {
                case "1":
                    Calculator.Add(number1, number2);
                    break;
                case "2":
                    Calculator.Subtract(number1, number2);
                    break;
                case "3":
                    Calculator.Multiply(number1, number2);
                    break;
                case "4":
                    Calculator.Divide(number1, number2);
                    break;
            }

            Console.WriteLine("-------------------------------------");
        }
    }
}