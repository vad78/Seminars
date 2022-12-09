/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4->24 5->120*/

int SetNum()
{
    int num = 0;
    Console.Write("Enter decimal number: ");
    while((Int32.TryParse(Console.ReadLine(), out num)==false)||num<0)
    {
        Console.Write("Enter correct decimal number: ");
    }
    return num;
    
} 
void SeriesOfNumMultiplication(int num)
{
    if(num==0)
    {
        Console.WriteLine(" Series is 0");
    }
    else
    {
        int result = 1;
        for(int i= 1;i<=num;i++)
        {
            result=result*i;
        }
        Console.WriteLine(result);
    }
}
int number = SetNum();
SeriesOfNumMultiplication(number);

