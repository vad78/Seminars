namespace Seminar3
{
    class MyIntMatrixArray
    {
        int [,]array;
        List<double> resultOfAverage;
    
        public MyIntMatrixArray(int rowCount, int cellCount)
        {
            this.array = new int [rowCount,cellCount];
            this.resultOfAverage = new List<double>();
            Random myRandomArray = new Random();
            for(int i = 0;i < rowCount;i++)
            {
                for(int j = 0;j < cellCount;j++)
                {
                    this.array[i,j] = (myRandomArray.Next(-100,100));
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
        public List<double> AverageOfRowsArray()
        {
            return CalcOfAverage();
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
                
            }
            Console.WriteLine();
        }

        private List<double> CalcOfAverage()
        {
            for (int i = 0;i<this.array.GetLength(0); i++)
            {
                int average = 0;
                for (int j = 0;j<this.array.GetLength(1); j++)
                {
                    average = average + this.array[i,j];
                }
                this.resultOfAverage.Add((double)average/this.array.GetLength(1));
                
            }
            return this.resultOfAverage;
            
        } 
    }
}