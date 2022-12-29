namespace Homework9Task3
{
    class Input
    {
        private int number;
        public int InputNumber()
        {
            this.number = Number();
            return this.number;
        }
       
        private int Number()
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
