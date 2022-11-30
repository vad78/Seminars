Console.Write("Enter first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(max<num2)
{
    Console.WriteLine("Maximum is "+num2+" and minimum is "+num1);
}
else
{
    Console.WriteLine("Maximum is "+num1+" and minimum is "+num2);
}