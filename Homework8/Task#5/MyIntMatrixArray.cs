namespace Task5
{
    class MyIntMatrixArray
    {
        private int[,] myArray;
        private int size;
        public MyIntMatrixArray(int sizeOfMatrix)
        {
            this.myArray = new int[sizeOfMatrix,sizeOfMatrix];
            this.size = sizeOfMatrix;
            
        }
        public void Print()
        {
            PrintArray();
        }
        public void CreateArray()
        {
            FillArray();
        }
        private void PrintArray()
        {
            string format = "00.##";
            for(int i = 0;i<this.myArray.GetLength(0);i++)
            {
                for(int j = 0;j<this.myArray.GetLength(1);j++)
                {
                    Console.Write($"{(this.myArray[i,j]).ToString(format)} ");
                }
                Console.WriteLine();
            } 
        }
        
        private void FillArray()
        {
            int x = 0,
                y = 0,
                steps = this.size;
            bool isStepEven = false,
                 isRow =true; 
                 

            
            for(int i = 1;i<=this.size;i++)
            {
                myArray[y,x] = i;
                if(i==)
                if(isStepEven&&isRow)
                {
                    x+=1;
                    myArray[y,x] = i;
                }
                if(isStepEven&&!isRow)
                {
                    y+=1;
                    myArray[y,x] = i;
                }
                if(!isStepEven&&isRow)
                {
                    x-=1;
                    myArray[y,x] = i;
                }

            }
            
            
        }
        
    }    
       
}