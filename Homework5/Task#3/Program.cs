/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
class Program
{
    public static void Main(string[] args)
    {
        Input MyNum = new Input();
        int number = MyNum.Num();
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
    class Array
    {
        //private int arraySize;
        private int[] array;
        public Array(int size)
        {
            //this.arraySize = size;
            int [] arr = new int[size];
            Random myRandom = new Random();
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = myRandom.Next(-100, 100);
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
         private void PrintArray()
        {
            Console.WriteLine("Array: "+string.Join(", ", this.array));
        }
        private (int,int) FindMaxMin()
        {
            int max = this.array[0],
                min = this.array[0];

            for(int i = 0;i < this.array.Length;i++)
            {
                if(max < this.array[i]) max = this.array[i];
                if(min > this.array[i]) min = this.array[i];
            }
            return (max,min);
        }
    }
}