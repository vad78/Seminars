/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
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
void GetCubeNum(int num)
{
   if(num!=0)
   { 
       
        for(int i = 1;i<=Math.Abs(num);i++)
        {
            if(num<0)
            {
                Console.Write($" {Math.Pow(-i, 3)}");
            }
            else
            {
                Console.Write($" {Math.Pow(i, 3)}");
            }
            
        }
   }
   else Console.Write("0");

}
int number = SetNum();
GetCubeNum(number);
 