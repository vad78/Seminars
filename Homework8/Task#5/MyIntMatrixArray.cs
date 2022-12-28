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
                minX = 0,
                minY = 0,
                maxX = this.myArray.GetLength(0)-1,
                maxY = this.myArray.GetLength(1)-1;
            for(int i = 1;i<=this.size;i++)
            {
                myArray[y,x] = i;               
                if(x>=minX&&x<maxX&&y>=minY&&y>maxY)
                {
                    x+=1;
                    myArray[y,x] = i; 
                }
                else
                {
                    
                }
            }
            
            
        }
        
    }    
       
}