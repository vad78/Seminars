/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
class Program
{
   static void Main(string[] args)
    {
       MyPow pow = new MyPow();
       pow.SetNumbers();
       pow.PowCalc();
    }
}
class MyPow
{
    
    private double number;
    private int pow;
    public void SetNumbers()
    {
        this.number = SetNum();
        this.pow = SetPow();
    }
    public void PowCalc()
    {
        CalcMyPow(number, pow);
    }
    private double SetNum()
    {
       double num = 0;
       Console.Write("Enter number: ");
       while((double.TryParse(Console.ReadLine(), out num)==false))
    {
        Console.Write("Enter correct number: ");
    }
    return num;
    
   }
   private int SetPow()
    {
       int num = 0;
       Console.Write("Enter degree number: ");
       while((Int32.TryParse(Console.ReadLine(), out num)==false))
    {
        Console.Write("Enter correct decimal number: ");
    }
    return num;
    
   }
   private void CalcMyPow( double num, int pow)
   {
       if(num == 0)
       {
            if (pow == 0)
            {
                Console.WriteLine($"Degree {num} in {pow} is 1");   
            }
            else
            {
                if(pow<0)
                {
                    Console.WriteLine($"Wrong number. It is prohibited to devide on zero");
                }
                else
                {
                    Console.WriteLine($"Degree {num} in {pow} is 0");
                }
            }
       
        }
        else
        {
           if(num>0)
            {
                if(pow>0)
                {
                    double result = 1;
                    for(int i = 1;i <= pow;i++)
                    {
                        result *= num;
                    }
                    Console.WriteLine($"Degree {num} in {pow} is {result}");
                }
                else
                {
                    double result = 1;
                    for(int i = 1;i <= Math.Abs(pow);i++)
                    {
                        result *=num;
                    }   
                
                Console.WriteLine($"Degree {num} in {pow} is {1/result}");
                }
            }             
             else
            {
                if(pow<0)
                {
                    double result = 1;
                    for(int i = 1; i <=Math.Abs(pow);i++)
                    {
                        result *=num;
                    }
                    Console.WriteLine($"Degree {num} in {pow} is {1/result}");
                }
                else
                {
                    double result = 1;
                    for(int i = 1; i <=pow;i++)
                    {
                        result *= num;
                    }
                    Console.WriteLine($"Degree {num} in {pow} is {result}");  
                }
            }            
       }           
   }
}       
   
  



