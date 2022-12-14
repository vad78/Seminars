
/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/
class Program
{
    static void Main(string[] args)
    {
        Random arrayRand = new Random();
        int[] myArray = FillArray();
        int number = CalcVolume(myArray);
        PrintArray(myArray);
        Console.WriteLine(number);
        void PrintArray(int[] arr)
        {
            Console.WriteLine($"array [ {string.Join(", ", arr)} ]");
        }
        int CalcVolume(int[] arr)
        {
            int num = 0;
            for(int i = 9;i<100;i++)
            {
                if(arr[i]<100&arr[i]>9) num+=1;

            }
            return num;
        }

        int [] FillArray()
        {
            int[] array = new int[123];
            for(int i=0;i<array.Length;i++)
            {
                array[i] = arrayRand.Next();
            }
            return array;
        }

    }
}