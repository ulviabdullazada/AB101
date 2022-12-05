
using Exceptions.Exceptions;
using Exceptions.Models;
using System.Reflection;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Try catch finally
            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine(a / b);
            //    throw new ArgumentException();
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Divide by zero Exception");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format Exception");
            //}
            //catch (SystemException)
            //{
            //    Console.WriteLine("System Exception");
            //}
            //finally
            //{
            //    Console.WriteLine("End");
            //}
            Console.WriteLine("122".Parse());
            Console.WriteLine("Some codes".Parse());
            #endregion
            #region Custom Exception
            //Group group = new Group();
            //group.Name = "ab101";
            //group.Students = new Student[5];
            //group.Students[0] = new Student { Id = "a103", Name = "Fateh", Surname = "Aliverdiyev" };
            //group.Students[1] = new Student { Id = "a155", Name = "Elkhan", Surname = "Mammadli" };
            //group.Students[2] = new Student { Id = "a130", Name = "Shahnaz", Surname = "Mammadova" };
            //group.Students[3] = new Student { Id = "a13", Name = "Ehtiram", Surname = "Shukurov" };
            //group.Students[4] = new Student { Id = "a203", Name = "Tural", Surname = "Asadli" };

            //try
            //{
            //    Console.WriteLine(group.HasStudent("203"));
            //    Console.WriteLine(group.HasStudent("a203"));
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            #endregion
            #region Reflection
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Type t = assembly.GetType("Exceptions.Models.Group");
            //Console.WriteLine(t);
            //foreach (Type type in assembly.GetTypes())
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine(type.Name + ":");
            //    foreach (var item in type.GetMembers())
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.WriteLine(item.Name);
            //    }
            //}

            //Group group = new Group();
            //var field = group.GetType().GetField("_privProp", BindingFlags.NonPublic | BindingFlags.Instance);
            //field.SetValue(group, 333);
            //Console.WriteLine(field.GetValue(group));

            //FieldInfo[] fields = group.GetFields(
            //             BindingFlags.NonPublic |
            //             BindingFlags.Instance);
            //group.PrintPriv();
            #endregion
            #region Casting

            #region Upcasting, Boxing
            Parrot pasha = new Parrot();
            //pasha.Talk();
            Animal bird = pasha;
            object a = new Shark();
            object[] objects = { pasha, bird, a, 7, 24 };
            Bird duck = new Duck();
            Animal penguin = new Penguin();
            Animal[] animals = { pasha, bird, new Shark(), duck, penguin};
            #endregion

            #region Downcasting, Unboxing
            //foreach (var item in animals)
            //{
            //    //Console.WriteLine(item.GetType().Name);
            //    //if (item is Bird b)
            //    //{
            //    //    //1:
            //    //    //Bird b = (Bird)item;
            //    //    //b.fly();
            //    //    //2:
            //    //    //((Bird)item).fly();
            //    //    //3 :
            //    //    b.Fly();
            //    //}
            //    //else if (item is Shark s)
            //    //{
            //    //    s.Swim();
            //    //}
            //    //Bird b = item as Bird;
            //    //Shark s = item as Shark;
            //    //if (b != null)
            //    //{
            //    //    b.Fly();
            //    //}
            //    //if (s != null)
            //    //{
            //    //    s.Swim();
            //    //};
            //}
            #endregion

            #endregion
        }
    }
}