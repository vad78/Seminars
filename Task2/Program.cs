Console.Write("Enter the number from 1 to 7 ");
int dayNum;
try
{
   dayNum = Convert.ToInt32(Console.ReadLine());
   if (dayNum==1) Console.WriteLine("Mon");
   if (dayNum==2) Console.WriteLine("Tue");
   if (dayNum==3) Console.WriteLine("Wed");
   if (dayNum==4) Console.WriteLine("Thurs");
   if (dayNum==5) Console.WriteLine("Fri");
   if (dayNum==6) Console.WriteLine("Sat");
   if (dayNum==7) Console.WriteLine("Sun");
   if (dayNum<0 | dayNum>8) Console.WriteLine("Wrong number was entered"); 

}
catch (System.IO.IOException e)
 {
    Console.WriteLine("Error wrong input" ,e.Message);
 }
