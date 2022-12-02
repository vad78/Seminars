//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98
int num = new Random().Next(100, 1000);
int lastDigit = num%10;
int firstDigit = num/100;
Console.WriteLine($"Initial num is {num} {firstDigit} {lastDigit}");

