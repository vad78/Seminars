//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
class Program
{
    public static void Main(string[] args)
    {
        Input MyNum = new Input();
        int number = MyNum.Num();
        SummArrayNum myEvenSumm = new SummArrayNum(number);
        myEvenSumm.Print();
        int summ = myEvenSumm.SummNonEvenMembers();
        Console.WriteLine($"The sum of non even array members is {summ}");

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
     class SummArrayNum
     {
        private int[] array;
        public SummArrayNum(int size)
        {
            int [] arr = new int[size];
            Random myRandom = new Random();
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = myRandom.Next(-100, 101);
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
        public int SummNonEvenMembers()
        {
            int sum = CalcNonEvenMembers();
            return sum;
        }
        
        private int CalcNonEvenMembers()
        {
             int summ = 0;
            for(int i = 1; i<this.array.Length;i+=2)
            {
                summ=summ+this.array[i];
            }
            return summ;
        }
         private void PrintArray()
        {
            Console.WriteLine("Array: "+string.Join(", ", this.array));
        }
     }
}
