/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

namespace Seminars
{
    class Program
    {
        public static void Main()
        {
            Input myMatrixSize = new Input();
            int rowCount = myMatrixSize.EnterMatrixSize().Item1;
            int cellCount = myMatrixSize.EnterMatrixSize().Item2;
            MyArrays myArray = new MyArrays(rowCount,cellCount);
            myArray.Print();
        }
    }
}
