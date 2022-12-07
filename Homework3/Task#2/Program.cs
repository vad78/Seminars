/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
int SetCoord(int point, int axis)
{
    string axisName = null;
    int num;
    switch(axis)
    {
        case 0:
        axisName = "x";
        break;
        case 1:
        axisName = "y";
        break;
        case 2:
        axisName = "z";
        break;
       
    } 
    Console.Write($"Enter coordinate for point: {axisName}{point+1} ");
    while(Int32.TryParse(Console.ReadLine(), out num)==false)
    {
        Console.Write($"Enter valid coordinate for point: {axisName}{point+1} ");
        
    }
    return num;
}
int [,] FillCoords()
{
    int [,] arr = new int[2,3];
    for(int i =0;i<2;i++)
    {
        for(int j= 0;j < 3;j++)
        {
            arr[i,j] = SetCoord(i, j);
        }

    }
    return arr;

}
int[,] coords;
coords = FillCoords();
double CalcDistance(int[,] arr)
{
    
    double summPow = 0;
    for(int j = 0;j<3;j++)
    {
        double summ = 0;
        for(int i=0;i<2;i++)
        {
            summ = summ + arr[i,j];
        }
        summPow = summPow + Math.Pow(summ, 2);
    }
    double result = Math.Sqrt(summPow);
    return result;
}
double dist = CalcDistance(coords);
Console.WriteLine($"Disctance is {dist}");
