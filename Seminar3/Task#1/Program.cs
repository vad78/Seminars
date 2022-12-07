int quarter=0;
bool isNum = false;
int GetQuarter()
{
    if(isNum == false||quarter<1||quarter>5)
    {
        isNum = Int32.TryParse(Console.ReadLine(), out quarter);
        Console.Write("Enter correct quarter number [1;4]: ");
    }
    return quarter;    

}

quarter = GetQuarter();
void OutputRange(int num)
{
    switch(num)
    {
        case 1:
        Console.WriteLine("x is <0, y >0");
        break;
        case 2:
        Console.WriteLine("x is >0, y >0");
        break;
        case 3:
        Console.WriteLine("x is >0, y <0");
        break;
        case 4:
        Console.WriteLine("x is <0, y <0");
        break;
        
    }
    
}
OutputRange(quarter);
