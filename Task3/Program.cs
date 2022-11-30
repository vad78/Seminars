Console.Write("Enter number ");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    if(num<=0)
    {
        Console.WriteLine("Wrong number, please enter unsigned value more than 0");
    }
    else 
    {
           for(int i = -num;i<num+1;i++)
       {
           Console.Write(" "+i);
       }
    }
    
}
catch (System.IO.IOException e)
{
    Console.WriteLine("Something went wrong", e.Message);
}
