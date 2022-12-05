namespace SealedStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sealed
            //FullStackDeveloper fsDev = new FullStackDeveloper();
            //fsDev.Name = "Elkhan";
            //fsDev.Surname = "Mammadli";
            //fsDev.SkillLevel = 1;
            //fsDev.Salary = 300;
            //Developer dev = new Developer()
            //{
            //    Salary = 300,
            //    Name = "Tarlan",
            //    Surname = "Heydarov"
            //};
            //dev.PrintInfo();
            //fsDev.PrintInfo();
            #endregion
            #region Nullable
            //ChangeId(3);
            string a = null;
            object o = null;
            Console.WriteLine(a);
            Console.WriteLine(o);
            #endregion
            #region Static
            //Program p = new Program();
            //p.PrintHello();
            Developer d = new Developer { Name = "Sanan", Surname = "Behbudov", Salary = 300 };
            Developer d1 = new Developer { Name = "Ulviyya", Surname = "Naghizada", Salary = 300 };
            Developer d2 = new Developer { Name = "Fateh", Surname = "Aliverdiyev", Salary = 300 };
            Developer d3 = new Developer { Name = "Farid", Surname = "Guliyev", Salary = 300 };
            //Console.WriteLine(d.Id);
            //Console.WriteLine(d1.Id);
            //Console.WriteLine(d2.Id);
            //Console.WriteLine(d3.Id);
            Test t = null;
            new Test();
            new Test();
            new Test();
            new Test();
            new Test();
            Test.Random();
            //Console.WriteLine(Test.Random(1,10));
            //Console.WriteLine(Test.Random(1,10));
            //Console.WriteLine(Test.Random(1,10));
            //Console.WriteLine(Test.Random(1,10));
            //Console.WriteLine(Test.Random(1,10));
            #endregion
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        public static void ChangeId(int? Id)
        {
            if (Id is null)
            {
                Console.WriteLine("Nulldu");
            }
            else
            {
                Console.WriteLine("Null deyil");
            }
        }
    }
}