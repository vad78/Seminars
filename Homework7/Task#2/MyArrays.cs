namespace Seminar2
{
    class MyArrays
    {
        double [,]array;
        public MyArrays(int rowCount, int cellCount)
        {
            this.array = new double[rowCount,cellCount];
            Random myRandomArray = new Random();
            for(int i = 0;i < rowCount;i++)
            {
                for(int j = 0;j < cellCount;j++)
                {
                    this.array[i,j] = (myRandomArray.Next(-100,100)*myRandomArray.NextDouble());
                }
            }
        }
        public void Print()
        {
            PrintMyArray();
        }
        public double FindElement(int row, int cell)
        {
            
            if(row<this.array.GetLength(0)||cell<this.array.GetLength(1)) {return this.array[row, cell];}
            else {return 0;}
        }
        private void PrintMyArray()
        {
            for(int i = 0; i<this.array.GetLength(0); i++)
            {
                Console.WriteLine();
                for(int j = 0; j<this.array.GetLength(1); j++)
                {
                     Console.Write(this.array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}