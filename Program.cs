using System;

namespace ConsoleApp1
{
    class Calc
    {
        static double Plus(double a, double b)
        {
            return a + b;
        }

        static double Minus(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Sinus(double a, double b)
        {
            return Math.Sin(a);
        }

        static double Cosinus(double a, double b)
        {
            return Math.Cos(a);
        }

        static double Tang(double a, double b)
        {
           return Math.Tan(a);
        }

        static double Root(double a, double b)
        {
            return Math.Sqrt(a);
        }

        static void Main()
        {     
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите тип операции: ");
            string oper = Console.ReadLine();
            double result = 0;
            
            switch (oper)
            {
                case "sin":
                    result = Math.Sin(num1);
                    break;                    
                case "cos":
                    result = Math.Cos(num1);
                    break;
                case "tan":
                    result = Math.Tan(num1);
                    break;
                case "sqrt":
                    result = Math.Sqrt(num1);
                    break;
                case "+":
                    result = Calc.Plus(num1, num2);
                    break;                    
                case "-":
                    result = Calc.Minus(num1, num2);
                    break;
                case "*":
                    result = Calc.Multiply(num1, num2);
                    break;
                case "/":
                    result = Calc.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Неверная операция.");
                    return;
            }
            Console.WriteLine(result);
        }
    }
}