/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5*/
//int number = 0;

int getNum()
{
    int num = 0;
    bool numCorrect = false;
    Console.Write("Enter 3 digits number: ");
    while((numCorrect==false) || (num<100 || num>999))
    {
        numCorrect = Int32.TryParse(Console.ReadLine(), out num);
        Console.Write("Enter correct 3 digits number: ");
    }
    return num;
}
void outputMiddleDigit(int num)
{
   int result = num/10%10;
   Console.WriteLine($"The middle digit is {result}");
}

int Number = getNum();
outputMiddleDigit(Number);



