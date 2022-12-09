/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3 78 -> 2 89126 -> 5*/
int SetNum()
{
    int num = 0;
    Console.Write("Enter decimal number: ");
    while((Int32.TryParse(Console.ReadLine(), out num)==false))
    {
        Console.Write("Enter correct decimal number: ");
    }
    return num;
    
} 
void GetDigits(int num)
{
   int result=0;
    while(num!=0)
    {
        num = num/10;
        result++;

    }
    Console.WriteLine(result);

}
int number = SetNum();
GetDigits(number);
