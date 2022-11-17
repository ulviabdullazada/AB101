namespace ReferenceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value and Reference types
            //int a = 10;
            //int b = a;
            //b += 30;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //int[] nums = { 1, 2, 3, 4, 5, 6 };
            //int[] nums1 = { 1, 2, 3, 4, 5, 6 };
            //int[] arr = new int[nums.Length];
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            //nums[0] = 10;
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(nums == arr);
            #endregion
            #region ref and out
            int number;
            //Console.WriteLine(number);
            //ChangeValue(ref number);
            //Console.WriteLine(number);

            //int[] nums = { 1, 2, 3, 4 };
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            //ChangeFirstIndex(nums);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //int.TryParse(Console.ReadLine(),out int b);
            //Console.WriteLine(b);
            Console.WriteLine("Uzunlugu daxil edin");
            int.TryParse(Console.ReadLine(), out int size);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            //int[] a = {1,2,3,4 };
            //AddLength(ref a, 5);
            //Console.WriteLine(a.Length);
            #endregion
        }
        #region ref and out
        static void ChangeValue(ref int num)
        {
            num = num + 30;
        }
        static void AddLength(ref int[] arr,int count)
        {
            int[] newArr = new int[arr.Length+count];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }
        //static void ChangeFirstIndex(int[] arr)
        //{
        //    arr[0] = 20;
        //}
        #endregion
    }
}