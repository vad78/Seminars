/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/
class Program
{
    static void Main(string[] args)
    {
        int size = GetMassiveSize();
        int [] initialArray = FillArray(size);
        int [] convertedArray = ConvertArray(initialArray);
        Console.WriteLine(string.Join(", ", convertedArray));
        int[] ConvertArray(int [] arr)
        {
             int [] arr2 = new int[size];
             for( int i =0;i<arr.Length;i++)
            {
             
                arr2[i] =arr[i]*-1;
                
            }
            return arr2;
            //Console.WriteLine(string.Join(", ", arr));
        }
        int[] FillArray(int ArraySize)
        {
            int [] arr = new int[size];
            for( int i =0;i<arr.Length;i++)
            {
                arr[i] = GetNum();
            }
            return arr;

        }
        int GetMassiveSize()
        {
             int num = 0;
            Console.Write("Enter array size number: ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false)||num<0)
            {
                Console.Write("Enter correct positive number: ");
            }
             return num;
        }
         int GetNum()
        {
            int num = 0;
            Console.Write("Enter number: ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false))
            {
                Console.Write("Enter correct number: ");
            }
             return num;
        }
    }
    
}