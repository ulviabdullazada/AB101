using A = AccessModifiers.Models.Abc.BCD.EFG;
namespace AccessModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {
            //A.Person p = new A.Person();
            //p.Name = "asdjkh";
            //Person a = new Person();
            //a.MyProperty = 213;
            ////p.
            ////Person a = new Person()
            ////p.Surname = "Heydarov";
            ////p.Salary2


            Test t = new Test();
            //t.Age = 22;
            Console.WriteLine(Test.Age);
        }
    }
    public class Person
    {
        public string A { get; set; }
        public int MyProperty { get; set; }
    }
    //private
    //public
    //internal
    //protected
    //private protected
    //protected internal
}