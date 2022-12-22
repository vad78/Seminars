/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
namespace Seminar3
{
    class Program
    {
        public static void Main()
        {
            Input myMatrixSize = new Input();
            int rowCount = myMatrixSize.IndexOfElement(1);
            int cellCount = myMatrixSize.IndexOfElement(2);
            MyIntMatrixArray myArray = new MyIntMatrixArray(rowCount,cellCount);
            myArray.Print();
            List<double> myAverage = myArray.AverageOfRowsArray();
            Console.WriteLine("Result of row average is "+string.Join(", ", myAverage));

        }
    }
}