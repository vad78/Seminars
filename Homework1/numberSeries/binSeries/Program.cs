using System.Collections;
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

int check = num%2;
if (check!=0) num=num-1;
Console.Write("Even numeric series: ");
for(int i=2;i<=num;i=i+2)
{
    Console.Write(i+" ");
}
 