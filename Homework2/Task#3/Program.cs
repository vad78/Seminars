/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
int getWeekDay()
{
    int day = 0;
    bool dayCorrect = false;
    Console.Write("Enter number: ");
    while(dayCorrect==false || day<0 || day>7)
    {
        dayCorrect = Int32.TryParse(Console.ReadLine(), out day);
        Console.Write("Enter correct weekday from 1 till 7: ");
    }
    return day;
}
void showWeekDay(int day)
{
      switch(day)
      {
        case 1:
        Console.WriteLine("Mon");
        break;
        case 2:
        Console.WriteLine("Tue");
        break;
        case 3:
        Console.WriteLine("Wed");
        break;
        case 4:
        Console.WriteLine("Thurs");
        break;
        case 5:
        Console.WriteLine("Fri");
        break;
        case 6:
        Console.WriteLine("Sat");
        break;
        case 7:
        Console.WriteLine("Sun");
        break;
      }
}

int weekDay = getWeekDay();
showWeekDay(weekDay);

