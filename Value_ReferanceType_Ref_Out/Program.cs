namespace Value_ReferanceType_Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { -1, 2, -3, 4, -5, 6 };   
            Method(ref arr1);                     //Ulvi mlm-in atdiqi sesden sonra basa dusduyum
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }


            int[] arr2 = { -1, 2, -3, 4, -5, 6 }; 
            Method( arr2);                        //ref olmadan
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            
            int[] arr3 = { -1, 2, -3, 4, -5, 6 }; 
            int[] newarr;
            Method(arr3, out newarr);             //Taski ilk defe oxuduqda bizden out ile yazmaqimizi istediyinizi dusundum
            foreach (var item in newarr)
            {
                Console.WriteLine(item);
            }

        }
        static void Method(ref int[] arr)   //Ulvi mlm-in atdiqi sesden sonradan basa dusduyum
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = (-1) * (arr[i]);
                }
            }
            Console.WriteLine("Ref işlederek: ");

        }

        static void Method(int[] arr)              //ref olanda da olmayandada bu formada yazdiqda isleyir
        {
            for (int i = 0; i < arr.Length; i++)  //mence arrayin her bir elementine muraciet edir deye bele olur butovlukde arrayi neyese mensub etsek ozaman ferqli olur
            {
                if (arr[i] < 0)
                {
                    arr[i] = (-1) * (arr[i]);
                }
            }
            Console.WriteLine("Ref və Out işlətmədən: ");

        }

        //static void Method(int[] arr1)              //ref olmadiqi ucun arrayi sonda basqa arraya mensub etsekde bu methoddan colde deyisiklik etmiyecek
        //{
        //    int[] arr = new int[arr1.Length];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = arr1[i];
        //    }
        //    for (int i = 0; i < arr.Length; i++)  
        //    {
        //        if (arr[i] < 0)
        //        {
        //            arr[i] = (-1) * (arr[i]);
        //        }
        //    }
        //    arr1 = arr;
        //    Console.WriteLine("Ref və Out işlətmədən: ");

        //}

        static void Method(int[] arr, out int[] newarr)   //Taski ilk defe oxuduqda anladigim qederi ile bunu istiyrdiz
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = (-1) * (arr[i]);
                }
            }
            newarr = arr;
            Console.WriteLine("Out işlederek: ");

        }



       


    }
}