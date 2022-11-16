using System.Security.Cryptography;

namespace Methods
{
    internal class Program
    {
        static int GetPercent(int num, int percent)
        {
            return num * percent / 100;
        }
        static void Main(string[] args)
        {
            //int salary = 800;
            //int bonusPercent = 10;
            //int result = salary * bonusPercent / 100;
            //Console.WriteLine(result);
            //int num1 = 90;
            //int num2 = 40;
            //int percent = num1 * num2 / 100;
            //Console.WriteLine(percent);
            //GetPercent(800, 10);
            //GetPercent(90, 40);
            //int salary = 800;
            //int percent = 10;
            //int result = GetPercent(salary, percent);
            //salary = salary + result;
            //Console.WriteLine(salary);
            //Sum(6, 7);
            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 10, 8 };
            //int[] arr2 = { 6, 10, 8 };

            //Console.WriteLine(Sum(1,2,3,6,7,8,9,10));
            //Console.WriteLine(Sum(1,5d));
            Test(14);
        }

        #region Methods
        //static void SayHello()
        //{
        //    Console.WriteLine("Hello");
        //}
        //static int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}
        #region Params
        //static int Sum(params int[] nums)
        //{
        //    int sum = 0;
        //    //foreach (int a in nums)
        //    //{
        //    //    sum = sum + a;
        //    //}
        //    //for (int i = 0; i < 4; i++)
        //    //{
        //    //    sum = sum + nums[i];
        //    //}
        //    return sum;
        //}
        #endregion
        #region Default parameter
        //static void PrintSum(int a1 = 30, int a2 = 50) //default parameter
        //{
        //    Console.WriteLine(Sum(a1,a2));
        //}
        #endregion
        #region Overloading
        //method signature - method name, method parameter count, method parameter type

        static void Test(int a)
        {
            Console.WriteLine("Simple method");
        }
        static string Test(params int[] a)
        {
            Console.WriteLine("Params method");
            return "";
        }
        static string Test(int a, int b = 22)
        {
            Console.WriteLine("Default parameter method");
            return "";
        }



        /// <summary>
        /// Gonderdiyiniz argumentleri toplamaq uchundur
        /// </summary>
        /// <param name="a1">ilk argument</param>
        /// <param name="a2">ikinci argument</param>
        /// <returns>Cemi</returns>

        //static int Sum(int a1, int a2)
        //{
        //return a1 + a2;
        //}
        //static double Sum(int a1, double a5)
        //{
        //    return a1+a5;
        //}
        //static double Sum(double a1, int a5)
        //{
        //    return a1 + a5;
        //}
        //static int Sum(int a1, int a2, int a3)
        //{
        //    return a1 + a2 + a3;
        //}


        #endregion
        #endregion



    }
}