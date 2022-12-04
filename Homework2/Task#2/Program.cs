/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
int getNum()
{
    int num = 0;
    bool numCorrect = false;
    Console.Write("Enter number: ");
    while(numCorrect==false)
    {
        numCorrect = Int32.TryParse(Console.ReadLine(), out num);
        Console.Write("Enter correct number: ");
    }
    return num;
}
void outputLastDigit(int num)
{
   if(num<999)
   {
      Console.WriteLine("The number is less than three digits"); 
   }
   else
   {
        int result = num/100%10;
        Console.WriteLine($"The third digit is {result}");
   }
   
}

int Number = getNum();
outputLastDigit(Number);