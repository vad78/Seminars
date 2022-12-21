/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Ai,j = i+j. 
Выведите полученный массив на экран.
m = 3, n = 4. 0 1 23
1 2 34
2 3 45*/
class Program
{
    public static void Main(string[] args)
    {
       MyMatrix matrix1 =new MyMatrix(2,5);
       matrix1.PrintArray();
    }
class MyMatrix
{
    //private double matrixRowCount, matrixString;
    private int [,] matrixArray;
    public MyMatrix(int numForMatrixString, int NumForMatrixRow)
    {
       int [,] arr= new int[numForMatrixString, NumForMatrixRow];
        for(int i = 0; i<arr.GetLength(0); i++)
        {
            for(int j = 0; j<arr.GetLength(1); j++)
            {
                arr[i,j] = i+j;
            }
        }
        this.matrixArray = arr;
    }
    public void PrintArray()
    {
       
        
        for(int i = 0; i<this.matrixArray.GetLength(0); i++)
        {
            Console.WriteLine();
            for(int j = 0; j<this.matrixArray.GetLength(1); j++)
            {
                Console.Write(this.matrixArray[i, j] + " ");
            }
        }
    }
 }
}