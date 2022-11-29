Console.Write("Enter first value ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enetr second value ");
int value2 = Convert.ToInt32(Console.ReadLine());
int pow1 = value1*value1;
if (pow1==value2*value2)
{
    Console.WriteLine("Value2 is the square of "+value1);
}
else
{
    Console.WriteLine("Value2 is not the square of "+value1);
}