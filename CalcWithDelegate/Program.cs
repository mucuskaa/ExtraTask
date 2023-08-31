﻿namespace CalcWithDelegate
{
    public delegate double Calculate(double a, double b);


    internal class Program
    {
        public static void Handler(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Division by zero is not allowed");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            double a, b;
            bool check = true;
            Calculate calculateDelegate = null;
            DivideByZero.DivideByZeroEvent += new EventHandler(Handler);



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


            switch (operation)
            {
                case '+':
                    calculateDelegate = (a, b) => (a + b);
                    break;
                case '-':
                    calculateDelegate = (a, b) => (a - b);
                    break;
                case '*':
                    calculateDelegate = (a, b) => (a * b);
                    break;
                case '/':
                    {
                        if (b == 0)
                        {
                            DivideByZero.EventInvoke();
                            check = false;
                        }
                        else
                        {

                            calculateDelegate = (a, b) => (a / b);
                        }

                        break;
                    }
            }
            if (check)
            {
                double res = calculateDelegate.Invoke(a, b);
                Console.WriteLine($"{a} {operation} {b} = {res}");
            }
        }
    }
}