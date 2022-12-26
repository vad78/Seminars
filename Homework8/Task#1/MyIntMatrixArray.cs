namespace Task1
{
    class MyIntMatrixArray
    {
        int [,]array;
      
    
        public void FillArray(int rowCount, int cellCount)
        {
            this.array = new int [rowCount,cellCount];
            Random myRandomArray = new Random();
            for(int i = 0;i < rowCount;i++)
            {
                for(int j = 0;j < cellCount;j++)
                {
                    this.array[i,j] = (myRandomArray.Next(0,100));
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
        public void Order()
        {
            OrderArray();
        }
        private void OrderArray()
        {
            int tmp =0;
            for(int i = 0; i < this.array.GetLength(0); i++)
            {
                for(int j = 0; j < this.array.GetLength(1)-1;j++)
                {
                    for (int k = j + 1; k < this.array.GetLength(1); k++)
                    {
                        if (this.array[i,j] < this.array[i,k])
                        {
                            tmp = this.array[i,j];
                            this.array[i,j] = this.array[i,k];
                            this.array[i,k] = tmp;
                        }  
                    }
                }
            }
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

        
    }
}