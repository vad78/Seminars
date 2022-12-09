int [] SetArray()
{
    Random rand = new Random();
    int [] myArray = new int[8];
    for(int i =0;i<8;i++)
    {
       
        myArray[i] = rand.Next(0, 2);
    }
return myArray;
}
void ArrayOutput(int [] arr)
{
    for(int i =0;i<8;i++)
    Console.Write($"{arr[i]} ");
}
int [] myArray = SetArray();
ArrayOutput(myArray);
