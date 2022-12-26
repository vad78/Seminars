namespace Task3
{
    class Program
    {
        public static void Main()
        {
            Input myMatrixSize = new Input();
            int rowCount = myMatrixSize.IndexOfElement(1);
            int cellCount = myMatrixSize.IndexOfElement(2);
            MyIntMatrixArray myArray = new MyIntMatrixArray();
            myArray.FillArray(rowCount, cellCount);
            int cellCountForArray2 = myMatrixSize.IndexOfElement(2);
            myArray.FillArray2(cellCountForArray2);
            myArray.PrintArrays();
        }
    }
}
