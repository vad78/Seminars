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
        int count = myArray.CalculateEvenNumbersCount();
        Console.WriteLine($"Count of even numbers is {count}");
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
    //method to get array from object is implemented
    class CalculatedArray
    {
        private int[] array;
        
        public CalculatedArray(int size)
        {
            
            int [] arr = new int[size];
            Random myRandom = new Random();
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = myRandom.Next(100, 1000);
            }
            this.array = arr;
        }
        // private methods
        public void Print()
        {
            PrintArray();
        }
        public int[]  GetArray()
        {
            return this.array;
        }
        public int CalculateEvenNumbersCount()
        {
            int count = CalcEvenCount();
            return count;
        }
        // private methods
        private int CalcEvenCount()
        {
            int count=0;
            for(int i=0;i<this.array.Length;i++)
            {
                if((this.array[i]%2)==0) count++;
                
            }
            return count;

        }
        private void PrintArray()
        {
            Console.WriteLine("Array: "+string.Join(", ", this.array));
        }

    }
}