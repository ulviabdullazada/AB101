namespace Delegate
{
    delegate bool CheckNumber<T> (T num);
    delegate void Change<T>(T str);
    delegate void ChangeFormat(string str);
    delegate T3 Calculate<in T1,in T2,out T3>(T1 num1, T2 num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 10, 100, 12, 88, 21, 0 };
            //CheckNumber[] funk = new CheckNumber[2];
            //funk[0] = IsEven;
            //funk[1] = IsDivide5;
            //Sum(arr, n => n % 10 == 0);
            //for (int i = 0; i < funk.Length; i++)
            //{
            //    Console.WriteLine(funk[i](5));
            //}
            //ChangeFormat format = PrintLower;
            //format += PrintCaptalize;
            ////lambda expression
            //format += salam => Console.WriteLine(salam.Substring(0, salam.Length - 1) + char.ToUpper(salam[salam.Length - 1]));
            //format -= salam => Console.WriteLine(salam.Substring(0, salam.Length - 1) + char.ToUpper(salam[salam.Length - 1])); ;
            //format("elXan");
            //Console.WriteLine(Calc(200,5, (elxan, fateh)=>elxan*fateh/2));
            //Predicate<int> funk;
            //funk = IsEven;
            //Sum(arr, IsEven);
            //Action<string> action = PrintUpper;
            //action += PrintLower;
            //action += PrintCaptalize;
            //action += str => Console.WriteLine(str.Trim());
            //action("  aBC");
            List<string> names = new List<string>();
            names.AddRange(new string[] { "Sanan", "Fateh", "Ulviyya", "Farid" });
            //foreach (var item in names.FindAll(name=>name.Contains('i')))
            //{
            //    Console.WriteLine(item);
            //}
            names.FindAll(name => name.Contains('i') && name.Length < 6).ForEach(name =>
            {
                Console.WriteLine(name);
            });
            //Console.WriteLine(names.Find(name=> name[0] == 'S'));
        }
        static void Sum(int[] arr, Predicate<int> ruslan)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (ruslan(item))
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
        static bool IsDivide3(int asdasd)
        {
            return asdasd % 3 == 0;
        }
        static bool IsDivide5(int num)
        {
            return num % 5 == 0;
        }
        static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }
        static void PrintUpper(string soz)
        {
            Console.WriteLine(soz.ToUpper());
        }
        static void PrintCaptalize(string str)
        {
            Console.WriteLine(Char.ToUpper(str[0]) + str.Substring(1).ToLower());
        }
        static int Calc(int num1, int num2, Func<int, int, int> funk)
        {
            return funk(num1, num2);
        }
        static int SumNums(int num1, int num2)
        {
            return num1+num2;
        }
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        static int Difference(int num1, int num2)
        {
            return num1 - num2;
        }
        static int CalcPercent(int num1, int num2) {
            return num1 * num2 / 100;
        }

    }
}