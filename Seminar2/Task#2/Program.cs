/*Напишите программу, которая будет принимать на вход два числа и
 выводить, является ли первое число кратным второму. Если число 2 не кратно числу 1, 
 то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно*/
Console.Write("Enter first num");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second num");
 int num2 = Convert.ToInt32(Console.ReadLine());
 if(num1%num2==0) 
 {
    Console.WriteLine("First num is multiple ");
 }
else
{
    Console.WriteLine("First num is not multiple ");
}

