/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int SetNum()
{
    int num = 0;
    Console.Write("Enter 5 digits number: ");
    while((Int32.TryParse(Console.ReadLine(), out num)==false)||num>99999||num<10000)
    {
        Console.Write("Enter 5 digits number: ");
    }
    return num;
    
} 
bool IsPolindrom(int num)
{
  bool polindrom = true;
  int i=1, digits=4;
  while(polindrom&&i<3)
   {
        
        int pow = Convert.ToInt32(Math.Pow(10,1));
        int num1=num%pow;
        int pow2 = Convert.ToInt32(Math.Pow(10, digits));
        int num2 = num/pow2;
        if(num1!=num2) polindrom=false;
        i++;
        digits=digits/2;
        pow2 = Convert.ToInt32(Math.Pow(10, 5-i));
        num = (num/pow)%pow2;
    }
   return polindrom;
     
}
int number = SetNum();
bool polindrom=IsPolindrom(number);
if(polindrom)
{
    Console.WriteLine("Yes, it is polindrom");
}
else
{
    Console.WriteLine("No, it is not polindrom");
}

