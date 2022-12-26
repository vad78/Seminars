
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
namespace Task2
{
    class Program
    {
        public static  void Main()
        {
            Input myMatrixSize = new Input();
            int size = myMatrixSize.IndexOfElement(1);
            MyIntMatrixArray myArray = new MyIntMatrixArray();
            myArray.FillArray(size,size);
            myArray.Print();
            int index = myArray.IndexOfMinSummRow();
            Console.WriteLine($"The index of row with minmul summ is {index}");
        }
    }
}
