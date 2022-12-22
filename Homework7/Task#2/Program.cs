/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
namespace Seminar2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Input myMatrixSize = new Input();
            int rowCount = myMatrixSize.ArraySize();
            int cellCount = myMatrixSize.ArraySize();
            MyArrays myArray = new MyArrays(rowCount,cellCount);
            myArray.Print();
            int row = myMatrixSize.IndexOfElement(1);
            int cell = myMatrixSize.IndexOfElement(2);
            double result = myArray.FindElement(row,cell);
            if(result!=0) { Console.WriteLine($"({row}, {cell}) = {result}");}
            else{Console.WriteLine("Out of range");}
        }
    }
}