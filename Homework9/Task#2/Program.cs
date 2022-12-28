/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
namespace Homework9Task2
{
    class Program
    {
        public static void Main()
        {
            Input myNum = new Input();
            int number1 = myNum.InputNumber();
            int number2 = myNum.InputNumber();
            if(number2<=number1)
            {
                Console.WriteLine($"Enter num greater than {number1}");
                number2 = myNum.InputNumber();
            }
            int summary = SummOfNum(number1, number2);
            Console.WriteLine($"The summ of numbers from {number1} to {number2} is {summary}");
            int SummOfNum(int startNum, int endNum)
            {
                             
                int summ = 0;
                if(startNum==endNum)
                {
                   
                    summ = startNum;
                }
                else
                {
                    summ = startNum+SummOfNum(startNum+1,endNum);    
                }
                return summ;
                
            }
        }
    }
}
        