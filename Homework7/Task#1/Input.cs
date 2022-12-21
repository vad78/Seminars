namespace Seminars
{
    class Input
    {
        private int number;
        public int ArraySize()
        {
            
            this.number = ArrSize();
            return this.number;
        }
       
        private int ArrSize()
        {
            int num = 0;
            Console.Write("Enter pozitive integer number: ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false)||num<=0)
            {
                Console.Write("Enter correct number: ");
            }
            return num;

        }    
    }
}