namespace Task3
{
    class MyIntMatrixArray
    {
        int [,]array;
        int [,]array2;
      
    
        public void FillArray(int rowCount, int cellCount)
        {
            this.array = new int [rowCount,cellCount];
            Random myRandomArray = new Random();
            for(int i = 0;i < rowCount;i++)
            {
                for(int j = 0;j < cellCount;j++)
                {
                    this.array[i,j] = (myRandomArray.Next(0,10));
                }
            }
        }
        public void FillArray2(int cellCount)
        {
            this.array2 = new int [this.array.GetLength(1),cellCount];
            Random myRandomArray = new Random();
            for(int i = 0;i < this.array.GetLength(0);i++)
            {
                for(int j = 0;j < cellCount;j++)
                {
                    this.array2[i,j] = (myRandomArray.Next(0,10));
                }
            }
        }
        public void PrintMultipleMatrix()
        {
            
            PrintMyArray(MultiplyArrays());
        }
        private int [,] MultiplyArrays()
        {
            int[,] resultArray = new int [this.array.GetLength(0), this.array2.GetLength(1)];
            for (int i= 0; i < this.array.GetLength(0); i++)
            {
                for (int j = 0; j < this.array2.GetLength(1); j++)
                {
                    for(int k = 0;k<this.array2.GetLength(0); k++)
                    {
                        resultArray[i,j]= resultArray[i,j] + this.array[i,k]*this.array2[k,j];
                    }
                }

            }
            return resultArray;
        }

        public int IndexOfMinSummRow()
        {
            return FindMinRow();
        }
        public void PrintArrays()
        {
            Console.WriteLine("Array1");
            PrintMyArray(this.array);
            Console.WriteLine("Array2");
            PrintMyArray(this.array2);
        }
        public void Print()
        {
            PrintMyArray(this.array);
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
        private int FindMinRow()
        {
            List<int> tmpSumm = new List<int>();
            for(int i = 0; i < this.array.GetLength(0); i++)
            {
                int summ = 0;
                for(int j = 0; j < this.array.GetLength(1);j++)
                {
                    summ +=this.array[i,j];

                }
                tmpSumm.Add(summ);
            }
            int min = tmpSumm[0];
            
            for(int i = 1;i <tmpSumm.Count; i++)
            {

                if(tmpSumm[i]<min)
                {
                    min = tmpSumm[i];
                }
            }
            return tmpSumm.IndexOf(min);

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
        private void PrintMyArray(int[,] arr)
        {
            for(int i = 0; i<arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for(int j = 0; j<arr.GetLength(1); j++)
                {
                     Console.Write(arr[i, j] + " ");
                }
                
            }
            Console.WriteLine();
        }

        
    }
}