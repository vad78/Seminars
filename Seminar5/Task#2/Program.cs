/*адача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/
class Program
{
    static void Main(string[] args)
    {
        
        int size = GetMassiveSize();
        int [] myArray = FillArray(size);
        int myNum = GetNum("to find");
        bool numExists = IsNumExists(myNum, myArray);
        if(numExists)
            {
                Console.WriteLine($"The number {numExists} exists in the array");
            }
            else
            {
               Console.WriteLine($"The number {numExists} does not exist in the array"); 
            }
        bool IsNumExists(int num, int[] arr)
        {
            bool isNum = false;
            for(int i = 0; i<arr.Length;i++)
            {
                if(arr[i] ==num) isNum = true;
                
            }

            return isNum;
            /*if(isNum)
            {
                Console.WriteLine($"The number {num} exists in the array");
            }
            else
            {
               Console.WriteLine($"The number {num} does not exist in the array"); 
            }*/
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
    }
}
