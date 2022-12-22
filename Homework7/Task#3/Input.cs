namespace Seminar3
{
    class Input
    {
        private int number, index;
        public int ArraySize()
        {
            
            this.number = ArrSize();
            return this.number;
        }
        public int IndexOfElement(int indexNum)
        {
            
            this.index = ElementNum(indexNum);
            return this.index;
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
        private int ElementNum(int index)
        {
            int num = 0;
            Console.Write($"Enter index{index} ");
            while((Int32.TryParse(Console.ReadLine(), out num)==false)||num<0)
            {
                Console.Write("Enter correct number:  ");
            }
            return num;

        }       
    }
}