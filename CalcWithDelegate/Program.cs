namespace CalcWithDelegate
{
    delegate double Calculate(double a, double b);
    internal class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.Incorrect result");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Input number A and number B");
            while (!double.TryParse(Console.ReadLine(), out a) || !double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Wrong input");
            }

            char operation;

            Console.WriteLine("Choose operation: +, -, *, /");
            while (!char.TryParse(Console.ReadLine(), out operation))
            {
                Console.WriteLine("Wrong input");
            }

            Calculate calculateDelegate=null;

            switch (operation)
            {
                case '+':
                    calculateDelegate = new Calculate(Add);
                    break;
                case '-':
                    calculateDelegate = new Calculate(Subtract);
                    break;
                case '*':
                    calculateDelegate = new Calculate(Multiply);
                    break;
                case '/':
                    calculateDelegate = new Calculate(Divide);
                    break;
            }

            double res=calculateDelegate.Invoke(a, b);
            Console.WriteLine($"{a} {operation} {b} = {res}");
        }
    }
}