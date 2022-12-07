/*Задача No22. Работа в группах
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4*/

Console.Write("Enter number: ");
int GetNum()
{
    bool isNum = false;
    int output = 0;
    while(isNum == false)
    {
        isNum = Int32.TryParse(Console.ReadLine(), out output);
        Console.WriteLine("Enter corret number");
    }
    return output;
}
int seriesNum = GetNum();

void PrintResult(int number)
{
   int i= 1;
   while(i<=number)
   {
        Console.WriteLine(Math.Pow(i, 2));
        i++;
   }
}
PrintResult(seriesNum);