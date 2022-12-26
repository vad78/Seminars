namespace Task4
{
    class MyIntMatrixArray
    {
        private int[] dictionary;
        private int[,,] myArray;
        public MyIntMatrixArray()
        {
            this.dictionary = new int[8];
            this.myArray = new int[2,2,2];
        }
        public void Print()
        {
            FillDictionary();
            FillArray();
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    for(int k = 0; k < 2; k++)
                    {
                        Console.Write($"{this.myArray[i,j,k]}({i},{j},{k}) "); 
                    }
                    Console.WriteLine();
                }
            } 
        }
        private void FillArray()
        {
            int indexOfDictionary = 0;
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    for(int k = 0; k < 2; k++)
                    {
                        this.myArray[i,j,k] = this.dictionary[indexOfDictionary]; 
                        indexOfDictionary++;
                    }
                }
            } 
        }
        private void FillDictionary()
        {
            Random myRandom = new Random();
            bool numExists = true;
            int number = myRandom.Next(0,100);
            this.dictionary[0]= number; 
            for( int i = 1; i<8; i++)
            {
               numExists = true;
                while(numExists)
                {
                    for(int j = 0; j<8; j++)
                    {
                        if(this.dictionary[j] == number) 
                        {
                            numExists = true;
                            
                        }
                        else{numExists = false;}
                    }
                number = myRandom.Next(0,100);   
                }
             this.dictionary[i] = number; 
            }
        }
    }
}