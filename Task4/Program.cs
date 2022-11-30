Console.Write("Enter three digits unsigned number ");
try 
{
   int num = Convert.ToInt32(Console.ReadLine());
   if(num<100 | num>1000)
   {
       Console.WriteLine("The wrong number has been entered");
   }
   else
   {
       int lastDigit = num%10;
       Console.WriteLine(lastDigit);
   }
}
catch (System.IO.IOException e)
{
       Console.WriteLine("Something went wrong "+e.Message);
}
