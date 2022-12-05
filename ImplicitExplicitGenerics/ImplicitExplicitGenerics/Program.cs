using System.Collections;

namespace ImplicitExplicitGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit, explicit, operator overloading
            //Manat manat = new Manat(3);
            //Dollar dollar = new Dollar(100);
            //Dollar d = new Dollar(50);
            ////Manat m = new Manat(600);
            ////Manat m1 = new Manat(700);
            //if (dollar == d)
            //{
            //    Console.WriteLine("m boyuk Beraberdir");
            //}
            //dollar = (Dollar)m1;
            //Console.WriteLine(dollar.USD);
            #endregion
            #region Non - Generic
            //ListInt list = new ListInt();
            //list.Add(1);
            //ListString str = new ListString();
            //str.Add("jskhdf");
            //str.Add("abc");
            //str.Add("123123");
            //str.Add("asdfasdf");
            //ListObject obj = new ListObject();
            //obj.Add(1);
            //obj.Add("abc");
            //obj.Add(new Exception());
            //obj.Add(true);
            //for (int i = 0; i < obj.Length; i++)
            //{
            //    Console.WriteLine(obj[i]);
            //}
            #endregion
            #region Generic
            //GenericList<string> genList = new GenericList<string>();
            //genList.Add("abc");
            //genList.Add("shjdfgsd");
            //genList.Add("hjdfghsjdfg");
            //for (int i = 0; i < genList.Count; i++)
            //{
            //    Console.WriteLine(genList[i]);
            //}
            GenericList<int> genList2 = new GenericList<int>();
            GenericList<string> genList1 = new GenericList<string>();
            genList2.Add(1);
            genList2.Add(1);
            genList2.Add(1);
            genList2.Add(1);
            //for (int i = 0; i < genList2.Count; i++)
            //{
            //    Console.WriteLine(genList2[i]);
            //}
            //Console.WriteLine(genList2[100]);
            //List<int> list = new List<int>();
            #endregion
        }
    }
    #region Implicit, explicit, operator overloading
    class Manat
    {
        public decimal AZN { get; set; }
        public Manat()
        {

        }
        public Manat(decimal aZN)
        {
            AZN = aZN;
        }
        public override string ToString()
        {
            return AZN + " manat";
        }
        //public static int Method(int a, int b)
        //{
        //    return a + b;
        //}
        public static bool operator == (Manat m1, Manat m2)
        {
            Console.WriteLine("Beraberlik yoxlanilir");
            return m1.AZN == m2.AZN;
        }
        public static bool operator == (Manat m, int num)
        {
            return m.AZN == num;
        }
        public static bool operator !=(Manat m, int num)
        {
            return m.AZN != num;
        }
        public static bool operator != (Manat m1, Manat m2)
        {
            return m1.AZN != m2.AZN;
        }
        public static bool operator >= (Manat m1, Manat m2)
        {
            return (m1.AZN >= m2.AZN);
        }
        public static bool operator <=(Manat m1, Manat m2)
        {
            return (m1.AZN <= m2.AZN);
        }
        public static int operator +(Manat m1, Manat m2)
        {
            return Convert.ToInt32(m1.AZN + m2.AZN);
        }
    }
    class Dollar : Manat
    {
        //public static explicit operator Manat(Dollar d)
        //{
        //    Manat m = new Manat(d.USD * 1.7m);
        //    return m;
        //}
        //public static explicit operator Dollar(Manat m)
        //{
        //    return new Dollar(m.AZN / 1.7m);
        //}
        public decimal USD { get; set; }
        public Dollar()
        {

        }
        public Dollar(decimal uSD) : base(uSD)
        {
            USD = uSD;
        }
        public override string ToString()
        {
            return USD + " dollar";
        }
    }

    #endregion
}