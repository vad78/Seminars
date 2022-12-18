/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
class Program
{
    public static void Main(string[] args)
    {
        Input MyNum = new Input();
        int k1 = MyNum.SetNumberForCoordinates("k1");
        int b1 = MyNum.SetNumberForCoordinates("b1");
        int k2 = MyNum.SetNumberForCoordinates("k2");
        int b2 = MyNum.SetNumberForCoordinates("b2");
        MyMath coordinates = new MyMath(k1,b1,k2,b2);
        coordinates.CalcCoordinatesForCross();
        


    }
    class Input
    {
        private int number;
        public int SetNumberForCoordinates(string number)
        {
          int num = InputFactor(number); 
          return num;
        }
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
        private int InputFactor(string number)
        {
            int num = 0;
            Console.Write($"Enter number for {number}: ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false)||num<=0)
            {
                Console.Write($"Enter correct number for {number}:");
            }
            return num;
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
    class MyMath
    {
        private int numForK1, numForB1, numForK2, numForB2
        public MyMath(int k1, int b1, int k2, int b2)
        {
            this.numForK1 = k1;
            this.numForB1 = b1;
            this.numForK2 = k2;
            this.numForB2 = b2;
        }
        public void CalcCoordinatesForCross()
        {
            double x, y;
            x = CalcCross().Item1;
            y = CalcCross().Item2;
            Console.WriteLine($"({x}, y{y})");
        }
        private (double,double) CalcCross()
        {
            double x, y;

            return (x,y);
        }
    }
   
      
    
}