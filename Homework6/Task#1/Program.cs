/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
class Program
{
    public static void Main(string[] args)
    {
        Input MyNum = new Input();
        int number = MyNum.ArraySize();
        Array myArray = new Array(number);
        myArray.Print();
        int count = myArray.CalcPositiveNumbers();
        Console.WriteLine($"The positive numbers count is {count}");


    }
    class Input
    {
        private int number;
        public int ArraySize()
        {
            ArrSize();
            return this.number;
        }
        private void ArrSize()
        {
            int num = 0;
            Console.Write("Enter pozitive integer number: ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false)||num<=0)
            {
                Console.Write("Enter correct number: ");
            }
            this.number = num;

        }    
        public int Num()
        {
            return this.number;
        }
        public  int SetNum()
        {
            int arrayMember = EnterNum();
            return arrayMember;
        }
        private int EnterNum()
        {
            int num = 0;
            Console.Write("Enter integer number: ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false))
            {
                Console.Write("Enter correct number: ");
            }
            return num;
        }
    }
    class Array
    {
        private int[] array;
        public Array(int size)
        {
            Input MyArrayMembers = new Input();
            int [] arr = new int [size];
            
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = MyArrayMembers.SetNum();
            }
            this.array = arr;
        }
        public void Print()
        {
            PrintArray();
        }
       
        public int[]  GetArray()
        {
            return this.array;
        }
        public int CalcPositiveNumbers()
        {
            int count = NumOfPositive();
            return count;
        }

        
        private int NumOfPositive()
        {
            int count = 0;
            for(int i = 0;i<this.array.Length;i++)
            {
                if(this.array[i]>0) count++;
            }
            return count;
        }
        private void PrintArray()
        {
            Console.WriteLine("Array: "+string.Join(", ", this.array));
        }
      
    }
}