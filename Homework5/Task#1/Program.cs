//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
class Program
{
    public static void Main(string[] args)
    {
        Input MyNum = new Input();
        int number = MyNum.Num();
        CalculatedArray myArray = new CalculatedArray(number);
        myArray.Print();
    }
    class Input
    {
        private int number;
        public Input()
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

    }
    class CalculatedArray
    {
        private int arraySize;
        private int[] array;
        public CalculatedArray()
        {
            arraySize = 0;
            int [] arr = new int[] {0};
            this.array = arr;
        }
        public CalculatedArray(int size)
        {
            this.arraySize = size;
            int [] arr = new int[arraySize];
            Random myRandom = new Random();
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = myRandom.Next(100, 1000);
            }
            this.array = arr;
        }
        public void Print()
        {
            PrintArray();
        }
        private void PrintArray()
        {
            Console.WriteLine("Array: "+string.Join(", ", this.array));
        }

    }
}