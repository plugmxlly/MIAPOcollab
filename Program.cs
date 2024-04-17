using System;

namespace ConsoleApp1
{
    class Calc
    {
        static void Main()
        {
            Console.WriteLine("Хэлоу ворлд!!!");

            switch (oper) {
                case '+':
                    Plus(num1, num2);
                    break;

                case '-':
                    Minus(num1, num2);
                    break;

                case '*':
                    Multiply(num1, num2);
                    break;

                case '/':
                    Divide(num1, num2);
                    break;

                default:
                    Console.WriteLine("Неизвестный оператор");
                    break;

            }
        }
    }
}