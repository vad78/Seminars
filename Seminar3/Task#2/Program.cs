

int GetCoordinates(string num)
{
   bool isNum = false;
   int coordinate=0;
    while(isNum == false)
    {
       {
            isNum = Int32.TryParse(Console.ReadLine(), out coordinate);
            Console.Write("Enter correct coordinate: " +num);
       }
    
    }
  return coordinate;    
 }
double CulcDistance(int x1, int y1, int x2, int y2)
{
   return Math.Sqrt( Math.Pow((x1-x2),2)+Math.Pow((x1-x2),2));
}
int x1 = GetCoordinates("x1");
int y1 = GetCoordinates("y1");
int x2 = GetCoordinates("x2");
int y2 = GetCoordinates("y2");
double disctance = CulcDistance(x1, y1, x2, y2); 
Console.WriteLine($"disctance is {disctance}");
