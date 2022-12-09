int [] SetArray(int num)
{
    Random rand = new Random();
    int [] myArray = new int[num];
    for(int i =0;i<myArray.Length;i++)
    {
       
        myArray[i] = rand.Next(0, 2);
    }
return myArray;
}
void ArrayOutput(int [] arr)
{
    for(int i =0;i<arr.Length;i++)
    Console.Write($"{arr[i]} ");
}

int range = int.Parse(Console.ReadLine());
int [] myArray = SetArray(range);
ArrayOutput(myArray);
