namespace Seminars
{
    class Input
    {
        private int number, number2;
        public int ArraySize()
        {
            ArrSize();
            return this.number;
        }
        public (int, int) EnterMatrixSize()
        {
            this.number = EnterNum();
            this.number2 = EnterNum();
            return (this.number, this.number2);
        
        }
        private void ArrSize()
        {
            int num = 0;
            Console.Write("Enter pozitive integer number: ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false)||num<=0)
            {
                Console.Write("Enter correct number: ");
            }
            this.number = num;

        }    
        public int Num()
        {
            return this.number;
        }
        public  int SetNum()
        {
            int arrayMember = EnterNum();
            return arrayMember;
        }
        private int EnterNum()
        {
            int num = 0;
            Console.Write("Enter integer number: ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false))
            {
                Console.Write("Enter correct number: ");
            }
            return num;
        }
    }
}