namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q_01 [Bubble Sort]
            int[] NumberArray = { 5, 8, 3, 4, 1, 9 };
            Helper.BubbleSort(NumberArray);
            PrintArray(NumberArray); 
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
