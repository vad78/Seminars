/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
int GetNum()
{
    int num = 0;
    bool numCorrect = false;
    Console.Write("Enter number: ");
    while(numCorrect==false||num<100)
    {
        numCorrect = Int32.TryParse(Console.ReadLine(), out num);
        if(numCorrect==false)
        {
             Console.Write("Enter correct number: ");
        }
       else
       {
            if(num<100)
            {
                Console.WriteLine("The number is less than three digits"); 
                Console.Write("Enter correct number: ");
            }
       }
       
    }
    return num;
}
void OutputLastDigit(int num)
{
   
    int result = num/100%10;
    Console.WriteLine($"The third digit is {result}");
   
   
}

int Number = GetNum();
OutputLastDigit(Number);