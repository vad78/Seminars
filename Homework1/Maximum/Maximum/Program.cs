int [] numbers = new int[3];
for(int i=0;i<3;i++)
{
    int numindex=i+1;
    Console.Write("Please enter num"+numindex+": ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int max=numbers[0];
for(int i=0;i<3;i++)
{
    if (numbers[i]>max) max=numbers[i];
}

Console.WriteLine("Maximum is "+max);
