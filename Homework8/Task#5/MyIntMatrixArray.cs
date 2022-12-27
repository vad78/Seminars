namespace Task5
{
    class MyIntMatrixArray
    {
        private int[,] myArray;
        private int size;
        public MyIntMatrixArray(int sizeOfMatrix)
        {
            this.myArray = new int[sizeOfMatrix,sizeOfMatrix];
            
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
            
            
            
        }
        
    }    
       
}