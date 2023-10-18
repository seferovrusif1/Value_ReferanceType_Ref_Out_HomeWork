namespace Value_ReferanceType_Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, 2, -3, 4, -5, 6 };
            int[] newarr;
            Method(arr, out newarr);
            foreach (var item in newarr)
            {
                Console.WriteLine(item);
            }
        }

        static void Method(int[] arr, out int[] newarr)   //Taski tam anlamadim anladigim qederi ile bunu istiyrsiz
        {
            for (int i = 0; i < arr.Length; i++)         
            {
                if (arr[i] < 0)
                {
                    arr[i] = (-1) * (arr[i]);
                }
            }
            newarr = arr;

        }

    }
}