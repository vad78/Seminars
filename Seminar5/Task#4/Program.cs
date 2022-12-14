/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/
class Program
{
    static void Main(string[] args)
    {
        int size = GetMassiveSize();
        
        int[] myArray = FillArray(size);
               
        int [] calculatedArray = CalcArray(myArray);
        PrintArray(calculatedArray);
        
        int [] CalcArray( int [] arr)
        {
            int resultArraySize;
            int NewArraySize(int mySize)
            {
                if(size%2>0)
                {
                    //Console.WriteLine(size/2+1);
                    return size/2+1;   
                }else
                {
                    //Console.WriteLine(size/2);
                    return size/2;
                }
            }
            resultArraySize = NewArraySize(arr.Length);
            int [] resArr = new int[resultArraySize];
            
            for(int i=0;i<resultArraySize;i++)
            {
                resArr[i] = arr[i]*arr[arr.Length-1-i];
                
            }    
            return resArr;        
                
        }

        
        int GetNum(string message)
         {
            int num = 0;
            Console.Write($"Enter number {message}: ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false))
            {
                Console.Write("Enter correct number: ");
            }
             return num;
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
        int[] FillArray(int ArraySize)
        {
            int [] arr = new int[size];
            for( int i =0;i<arr.Length;i++)
            {
                arr[i] = GetNum("for array");
            }
            return arr;

        }
        void PrintArray(int[] arr)
        {
            Console.WriteLine($"array [ {string.Join(", ", arr)} ]");
        }
    }
}
