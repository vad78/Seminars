/* 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет 46 -> нет 161 -> да*/
Console.Write("Enter num ");
int num = Convert.ToInt32(Console.ReadLine());

 if((num%7==0)&(num%23==0)) 
 {
    Console.WriteLine("The num is multiple to 7 and 23");
 }
else
{
    Console.WriteLine("The num is not multiple to 7 and 23");
}