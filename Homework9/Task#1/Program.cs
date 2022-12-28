/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
namespace Homework9Task1
{
    class Program
    {
        public static void Main()
        {
            void serialOfNumbers(int Number)
            {
            //Console.WriteLine();
                if(Number == 0)
                {
                    return;
                }
                else
                {
                    Console.Write($"{Number} ");
                    serialOfNumbers(Number-1);
                }                  
            }
            Input myNum = new Input();
            int number = myNum.InputNumber();
            serialOfNumbers(number);    
        }
    }
}
