/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
class Program
{
   static void Main(string[] args)
    {
       DigitsSum mySumOfDigits = new DigitsSum();
       mySumOfDigits.SetNum();
       mySumOfDigits.PrintSumOfDigits();
    }
}
class DigitsSum
{
    private int number;
    
    public void SetNum()
    {
        this.number = Num();
    }
    public void PrintSumOfDigits()
    {
        int sum = SumOfDigits(number);
        Console.WriteLine($"Sum of digits in the {number} is {sum}");
    }
    private int Num()
    {
       int num = 0;
       Console.Write("Enter degree number: ");
       while((Int32.TryParse(Console.ReadLine(), out num)==false))
       {
         Console.Write("Enter correct decimal number: ");
       }
       return num;
    }
   
   private int SumOfDigits(int num)
   {
        int remainder = num, sum= 0;    
        while(remainder!=0)
        {
             remainder = num%10;
             sum = sum+remainder;
             num = num/10;   
        }
        return sum;
   }
}