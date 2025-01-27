namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q_01 [Bubble Sort]
            int[] NumberArray = { 5, 8, 3, 4, 1, 9 };
            //Helper.BubbleSort(NumberArray);
            //PrintArray(NumberArray); 
            #endregion

            #region Q_02[Genaric]
            Range<int> RangeNumber = new Range<int>(2,10);
            Console.WriteLine($"Is value in Range : {RangeNumber.IsInRange(5)}");
            Console.WriteLine($"The lenght of the Range is : {RangeNumber.Length()}");
            #endregion
        }
        public static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
