/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
class Program
{
   static void Main(string[] args)
    {
        MyArray Array1 = new MyArray();
        Array1.SetArray();
        Array1.PrintArray();
    }
}
class MyArray
{
    private int [] array = new int[8];
    
    public void SetArray()
    {
        this.array = Array();
    }
    public void PrintArray()
    {
        OutputArray(array);
    }
    private void OutputArray(int [] array)
    {
        for(int i = 0;i<array.Length;i++)
        {
            Console.Write($"{array[i]}, ");
        }           
    } 
    private int[] Array()
    {
       int num;
       int [] privateArray = new int[8];
       for(int i = 0;i<privateArray.Length;i++)
       {
            Console.Write($"Enter number {i+1}: ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false))
            {
                Console.Write("Enter correct decimal number: ");
            }
            privateArray[i]= num;
       }
       return privateArray;
    }
       
  
}